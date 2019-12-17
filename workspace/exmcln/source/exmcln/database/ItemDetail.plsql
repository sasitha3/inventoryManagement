-----------------------------------------------------------------------------
--
--  Logical unit: ItemDetail
--  Component:    EXMCLN
--
--  IFS Developer Studio Template Version 3.0
--
--  Date    Sign    History
--  191217  Sapdlk  Created check deliveries
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
      Cus_Order_Details_API.Change_State(rec_.ORDER_NO);
   END IF;
END Qty_Deduction___;
-------------------- LU SPECIFIC PRIVATE METHODS ----------------------------


-------------------- LU SPECIFIC PROTECTED METHODS --------------------------


-------------------- LU SPECIFIC PUBLIC METHODS -----------------------------

