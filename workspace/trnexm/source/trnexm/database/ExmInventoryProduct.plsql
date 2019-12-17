-----------------------------------------------------------------------------
--
--  Logical unit: ExmInventoryProduct
--  Component:    TRNEXM
--
--  IFS Developer Studio Template Version 3.0
--
--  Date    Sign    History
--  191212  Sapdlk  Created add product method
--  191216  Sapdlk  Created deduct product method
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
   inventory_id_    IN EXM_INVENTORY_PRODUCT_TAB.inventory_id%TYPE,
   part_no_         IN EXM_INVENTORY_PRODUCT_TAB.part_no%TYPE,
   quantity_        IN EXM_INVENTORY_PRODUCT_TAB.quantity%TYPE)
IS
   
   rec_           EXM_INVENTORY_PRODUCT_TAB%ROWTYPE;
   objid_         VARCHAR2(1000);
   objversion_    VARCHAR2(1000);
   attr_          VARCHAR2(2000);
   info_          VARCHAR2(32000);
BEGIN
   
   IF Check_Exist___( location_number_, inventory_id_, part_no_ ) THEN 
      Get_Id_Version_By_Keys___(objid_, objversion_, location_number_, inventory_id_, part_no_);
      rec_ := Lock_By_Keys___(location_number_, inventory_id_, part_no_);
      
      Client_SYS.Add_To_Attr('QUANTITY', rec_.quantity + quantity_, attr_);
      
      Modify__(info_, objid_, objversion_, attr_, 'DO'); 
      
   ELSE
      
      Client_SYS.Add_To_Attr('INVENTORY_ID', inventory_id_, attr_);
      Client_SYS.Add_To_Attr('LOCATION_NUMBER', location_number_, attr_);
      Client_SYS.Add_To_Attr('PART_NO', part_no_, attr_);
      Client_SYS.Add_To_Attr('QUANTITY', quantity_, attr_);
      New__(info_, objid_, objversion_, attr_, 'DO');
      
   END IF;
   
END Add_prudct;

FUNCTION Deduct_prudct (
   
   part_no_  IN EXM_INVENTORY_PRODUCT_TAB.part_no%TYPE,
   quantity_ IN EXM_INVENTORY_PRODUCT_TAB.quantity%TYPE)
   RETURN BOOLEAN
IS
   
   rec_           EXM_INVENTORY_PRODUCT_TAB%ROWTYPE;
   objid_         VARCHAR2(1000);
   objversion_    VARCHAR2(1000);
   attr_          VARCHAR2(2000);
   info_          VARCHAR2(32000);
   total_qty_part_ NUMBER;
   total_quantity_ NUMBER;
   CURSOR get_inventory_product_tot IS
      SELECT SUM(eip.quantity)
      FROM Exm_Inventory_Product_TAB eip
      WHERE eip.part_no = part_no_;
   
   CURSOR get_inventory_products IS
      SELECT eip.location_number, eip.inventory_id, eip.part_no, eip.quantity
      FROM Exm_Inventory_Product_TAB eip
      WHERE eip.part_no = part_no_
      ORDER BY eip.quantity;
BEGIN
   total_quantity_ := quantity_;
   OPEN get_inventory_product_tot;
   FETCH get_inventory_product_tot INTO total_qty_part_;
   CLOSE get_inventory_product_tot;
   IF (total_qty_part_ >= quantity_) THEN
      FOR all_rec_ IN get_inventory_products LOOP
         
         IF(all_rec_.quantity >= total_quantity_) THEN
            
            Get_Id_Version_By_Keys___(objid_, objversion_, all_rec_.location_number, all_rec_.inventory_id, part_no_);
            rec_ := Lock_By_Keys___(all_rec_.location_number, all_rec_.inventory_id, part_no_);
            
            Client_SYS.Add_To_Attr('QUANTITY', all_rec_.quantity - total_quantity_, attr_);
            
            Modify__(info_, objid_, objversion_, attr_, 'DO'); 
            RETURN TRUE;
         ELSE
            total_quantity_ := total_quantity_ - all_rec_.quantity;
            
            Get_Id_Version_By_Keys___(objid_, objversion_, all_rec_.location_number, all_rec_.inventory_id, part_no_);
            rec_ := Lock_By_Keys___(all_rec_.location_number, all_rec_.inventory_id, part_no_);
            
            Client_SYS.Add_To_Attr('QUANTITY', 0, attr_);
            
            Modify__(info_, objid_, objversion_, attr_, 'DO'); 
            
         END IF;
      END LOOP;
      
   ELSE
      RETURN FALSE;
      
   END IF;
END Deduct_prudct;