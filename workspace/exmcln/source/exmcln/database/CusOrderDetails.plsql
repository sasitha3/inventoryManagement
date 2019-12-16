-----------------------------------------------------------------------------
--
--  Logical unit: CusOrderDetails
--  Component:    EXMCLN
--
--  IFS Developer Studio Template Version 3.0
--
--  Date    Sign    History
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
-------------------- LU SPECIFIC PRIVATE METHODS ----------------------------


-------------------- LU SPECIFIC PROTECTED METHODS --------------------------


-------------------- LU SPECIFIC PUBLIC METHODS -----------------------------

