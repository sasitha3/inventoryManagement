-----------------------------------------------------------------------------
--
--  Logical unit: ItemDetail
--  Component:    EXMCLN
--
--  IFS Developer Studio Template Version 3.0
--
--  Date    Sign    History
--  191217  Sapdlk  Created check deliveries
--  191217  Sapdlk  Rewrite DO function Qty_Deduction___
--  191217  Sapdlk  Created Any Deliver
--  191217  Sapdlk  Check_Order_State___ condition method rewrite
--  ------  ------  ---------------------------------------------------------
-----------------------------------------------------------------------------

layer Core;

-------------------- PUBLIC DECLARATIONS ------------------------------------


-------------------- PRIVATE DECLARATIONS -----------------------------------


-------------------- LU SPECIFIC IMPLEMENTATION METHODS ---------------------

FUNCTION Check_Deliveries___(order_number_ IN NUMBER) RETURN BOOLEAN
IS
   delivered_count_value_ NUMBER;
   all_count_value_ NUMBER;
   CURSOR all_count_ IS
      SELECT COUNT(ITEM_NO) 
      FROM ITEM_DETAIL_TAB idt
      WHERE idt.ORDER_NO = order_number_;
   CURSOR deliver_count_ IS
      SELECT COUNT(ITEM_NO) 
      FROM ITEM_DETAIL_TAB idt
      WHERE (ROWSTATE = 'Delivered' OR ROWSTATE = 'Cancelled' ) AND idt.ORDER_NO = order_number_;
BEGIN
   OPEN all_count_;
   FETCH all_count_ INTO all_count_value_;
   CLOSE all_count_;
   OPEN deliver_count_;
   FETCH deliver_count_ INTO delivered_count_value_;
   CLOSE deliver_count_;
   IF(all_count_value_ - 1 = delivered_count_value_) THEN
      RETURN TRUE;
   ELSE
      RETURN FALSE;
   END IF;
END Check_Deliveries___; 

PROCEDURE Qty_Deduction___ (
   rec_  IN OUT NOCOPY item_detail_tab%ROWTYPE,
   attr_ IN OUT NOCOPY VARCHAR2 )
IS
   
BEGIN
   IF (Check_Deliveries___(rec_.ORDER_NO)) THEN
      IF(Exm_Inventory_Product_API.Deduct_Prudct(rec_.item_no, rec_.quantity))THEN
         Cus_Order_Details_API.Change_State(rec_.ORDER_NO);
      END IF;
   END IF;
END Qty_Deduction___;

FUNCTION Check_Order_State___ (
   rec_  IN     item_detail_tab%ROWTYPE ) RETURN BOOLEAN
IS
   rowstate_ VARCHAR2(10);
BEGIN
   rowstate_ := Cus_Order_Details_API.Get(rec_.order_no).rowstate;
   IF (rowstate_ = 'Released') THEN
      RETURN TRUE;
   END IF;
   RETURN FALSE;
END Check_Order_State___;

-------------------- LU SPECIFIC PRIVATE METHODS ----------------------------


-------------------- LU SPECIFIC PROTECTED METHODS --------------------------


-------------------- LU SPECIFIC PUBLIC METHODS -----------------------------
FUNCTION Any_Deliver( 
                      action_param_ IN VARCHAR2,
                      order_no_     IN NUMBER
                      ) RETURN BOOLEAN
IS
   delivered_count_value_ NUMBER;
   del_remcount_value_ NUMBER;
   
   CURSOR deliver_count_ IS
      SELECT COUNT(ITEM_NO) 
      FROM ITEM_DETAIL_TAB idt
      WHERE ROWSTATE = 'Delivered' AND idt.ORDER_NO = order_no_;
   
   CURSOR deliver_remaining_count_ IS
      SELECT COUNT(ITEM_NO) 
      FROM ITEM_DETAIL_TAB idt
      WHERE ROWSTATE = 'Required' AND idt.ORDER_NO = order_no_;
BEGIN
   
   IF (action_param_ = 'ANY') THEN
      OPEN deliver_count_;
   FETCH deliver_count_ INTO delivered_count_value_;
   CLOSE deliver_count_;
      IF(delivered_count_value_ > 0) THEN
         RETURN TRUE;
      ELSE
         RETURN FALSE;
      END IF;
      
   ELSIF(action_param_ = 'NO') THEN
      OPEN deliver_remaining_count_;
   FETCH deliver_remaining_count_ INTO del_remcount_value_;
   CLOSE deliver_remaining_count_;
      IF(del_remcount_value_ > 0) THEN
         RETURN TRUE;
      ELSE
         RETURN FALSE;
      END IF;
   END IF;
END Any_Deliver; 
