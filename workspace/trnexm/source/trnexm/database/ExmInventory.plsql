-----------------------------------------------------------------------------
--
--  Logical unit: ExmInventory
--  Component:    TRNEXM
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
   newrec_     IN OUT exm_inventory_tab%ROWTYPE,
   attr_       IN OUT VARCHAR2 )
IS
   inventory_id_ NUMBER;
BEGIN
   --Add pre-processing code here
   inventory_id_ := PROD_INVENTORY_ID_SEQ.NEXTVAL;
   newrec_.inventory_id := inventory_id_;
   super(objid_, objversion_, newrec_, attr_);
   Client_SYS.Add_To_Attr('INVENTORY_ID', inventory_id_, attr_);
   --Add post-processing code here
END Insert___;



-------------------- LU SPECIFIC PRIVATE METHODS ----------------------------


-------------------- LU SPECIFIC PROTECTED METHODS --------------------------


-------------------- LU SPECIFIC PUBLIC METHODS -----------------------------

