-----------------------------------------------------------------------------
--
--  Logical unit: CusOrderDetails
--  Component:    EXMCLN
--
--  IFS Developer Studio Template Version 3.0
--
--  Date    Sign    History
--  191211  Sapdlk  Override Insert___ method
--  191217  Sapdlk  New public method  change state
--  191217  Sapdlk  Re wrute the condition created on cancel
--  ------  ------  ---------------------------------------------------------
-----------------------------------------------------------------------------

layer Core;

-------------------- PUBLIC DECLARATIONS ------------------------------------


-------------------- PRIVATE DECLARATIONS -----------------------------------


-------------------- LU SPECIFIC IMPLEMENTATION METHODS ---------------------

@Override
PROCEDURE Insert___ (
   objid_      OUT    VARCHAR2,
   objversion_ OUT    VARCHAR2,
   newrec_     IN OUT CUS_ORDER_DETAILS_TAB%ROWTYPE,
   attr_       IN OUT VARCHAR2 )
IS
   cus_order_id_ NUMBER;
BEGIN
   --Add pre-processing code here
   cus_order_id_ := CUS_ORDER_ID_SEQ.NEXTVAL;
   newrec_.order_no := cus_order_id_;
   super(objid_, objversion_, newrec_, attr_);
   Client_SYS.Add_To_Attr('ORDER_NO', cus_order_id_, attr_);
   --Add post-processing code here
END Insert___;

FUNCTION Check_Parts___ (
   rec_ IN cus_order_details_tab%ROWTYPE ) RETURN BOOLEAN
IS
   
BEGIN
   
   IF( Item_Detail_API.Any_Deliver('ANY', rec_.order_no) ) THEN
      
      RETURN TRUE;
   ELSE
      RETURN FALSE;
   END IF;
   
END Check_Parts___;

FUNCTION No_Delivers___ (
   rec_ IN cus_order_details_tab%ROWTYPE ) RETURN BOOLEAN
IS
   
BEGIN
   IF( Item_Detail_API.Any_Deliver('NO', rec_.order_no) ) THEN
      
      RETURN TRUE;
   ELSE
      RETURN FALSE;
   END IF;
END No_Delivers___;
-------------------- LU SPECIFIC PRIVATE METHODS ----------------------------


-------------------- LU SPECIFIC PROTECTED METHODS --------------------------


-------------------- LU SPECIFIC PUBLIC METHODS -----------------------------
PROCEDURE Change_State(
   order_no_ IN NUMBER
   )
IS
   rec_ cus_order_details_tab%ROWTYPE;
   CURSOR order_detail_ IS
      SELECT * 
      FROM CUS_ORDER_DETAILS_TAB ct
      WHERE ct.ORDER_NO = order_no_;
BEGIN
   OPEN order_detail_;
   FETCH order_detail_ INTO rec_;
   CLOSE order_detail_;
   
   Finite_State_Set___(rec_, 'Released');
END Change_State;
