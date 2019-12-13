-----------------------------------------------------------------------------
--
--  Logical unit: ExmInventoryProduct
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


-------------------- LU SPECIFIC PRIVATE METHODS ----------------------------


-------------------- LU SPECIFIC PROTECTED METHODS --------------------------


-------------------- LU SPECIFIC PUBLIC METHODS -----------------------------

PROCEDURE Add_prudct (
   location_number_ IN EXM_INVENTORY_PRODUCT_TAB.location_number%TYPE,
   inventory_id_ IN EXM_INVENTORY_PRODUCT_TAB.inventory_id%TYPE,
   part_no_ IN EXM_INVENTORY_PRODUCT_TAB.part_no%TYPE,
   quantity_ IN trn_inventory_product_tab.quantity%TYPE)
IS
   
   rec_           EXM_INVENTORY_PRODUCT_TAB%ROWTYPE;
   objid_         VARCHAR2(1000);
   objversion_    VARCHAR2(1000);
   attr_          VARCHAR2(2000);
   info_          VARCHAR2(32000);
BEGIN
   --General_Sys.Init_Method(lu_name_, '&PKG', 'Move_prudct');
   IF Check_Exist___( location_number_, inventory_id_, part_no_ ) THEN 
      Get_Id_Version_By_Keys___(objid_, objversion_, location_number_, inventory_id_, part_no_);
      rec_ := Lock_By_Keys___(location_number_, inventory_id_, part_no_);

      Client_Sys.Add_To_Attr('QUANTITY', rec_.quantity + quantity_, attr_);
      
      Modify__(info_, objid_, objversion_, attr_, 'DO'); 
      
   ELSE
         
         Client_Sys.Add_To_Attr('INVENTORY_ID', inventory_id_, attr_);
         Client_Sys.Add_To_Attr('LOCATION_NUMBER', location_number_, attr_);
         Client_Sys.Add_To_Attr('PART_NO', part_no_, attr_);
         Client_Sys.Add_To_Attr('QUANTITY', quantity_, attr_);
         New__(info_, objid_, objversion_, attr_, 'DO');
         
   END IF;
END Add_prudct;