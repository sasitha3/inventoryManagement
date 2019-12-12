-----------------------------------------------------------------------------
--
--  Logical unit: ExmInventoryProduct
--  Component:    TRNEXM
--
--  Template:     3.0
--  Built by:     IFS Developer Studio 10.82.6479.20191204
--
--  NOTE! Do not edit!! This file is completely generated and will be
--        overwritten next time the corresponding model is saved.
-----------------------------------------------------------------------------

layer Base;

-------------------- PUBLIC DECLARATIONS ------------------------------------

--TYPE Primary_Key_Rec IS RECORD
--  (location_number                EXM_INVENTORY_PRODUCT_TAB.location_number%TYPE,
--   inventory_id                   EXM_INVENTORY_PRODUCT_TAB.inventory_id%TYPE,
--   part_no                        EXM_INVENTORY_PRODUCT_TAB.part_no%TYPE);

TYPE Public_Rec IS RECORD
  (location_number                EXM_INVENTORY_PRODUCT_TAB.location_number%TYPE,
   inventory_id                   EXM_INVENTORY_PRODUCT_TAB.inventory_id%TYPE,
   part_no                        EXM_INVENTORY_PRODUCT_TAB.part_no%TYPE,
   "rowid"                        rowid,
   rowversion                     EXM_INVENTORY_PRODUCT_TAB.rowversion%TYPE,
   rowkey                         EXM_INVENTORY_PRODUCT_TAB.rowkey%TYPE,
   quantity                       EXM_INVENTORY_PRODUCT_TAB.quantity%TYPE);

-------------------- PRIVATE DECLARATIONS -----------------------------------

TYPE Indicator_Rec IS RECORD
  (location_number                BOOLEAN := FALSE,
   inventory_id                   BOOLEAN := FALSE,
   part_no                        BOOLEAN := FALSE,
   quantity                       BOOLEAN := FALSE);

-------------------- BASE METHODS -------------------------------------------

-- Raise_Too_Many_Rows___
--    Raises error for: More then one row found for a single key.
PROCEDURE Raise_Too_Many_Rows___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER,
   methodname_ IN VARCHAR2 )
IS
BEGIN
   Error_SYS.Too_Many_Rows(Exm_Inventory_Product_API.lu_name_, NULL, methodname_);
END Raise_Too_Many_Rows___;


-- Raise_Record_Not_Exist___
--    Raises error for: No data found for given key.
PROCEDURE Raise_Record_Not_Exist___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER )
IS
BEGIN
   Error_SYS.Record_Not_Exist(Exm_Inventory_Product_API.lu_name_);
END Raise_Record_Not_Exist___;


-- Raise_Record_Exist___
--    Raises error for: Data with given key value already exist.
PROCEDURE Raise_Record_Exist___ (
   rec_ exm_inventory_product_tab%ROWTYPE )
IS
BEGIN
   Error_SYS.Record_Exist(Exm_Inventory_Product_API.lu_name_);
END Raise_Record_Exist___;


-- Raise_Item_Format___
--    Raises error for: Data value format is incorrect.
PROCEDURE Raise_Item_Format___ (
   name_ IN VARCHAR2,
   value_ IN VARCHAR2 )
IS
BEGIN
   Error_SYS.Item_Format(Exm_Inventory_Product_API.lu_name_, name_, value_);
END Raise_Item_Format___;

-- Raise_Record_Modified___
--    Raises error for: The database row is newer then the current.
PROCEDURE Raise_Record_Modified___ (
   rec_ exm_inventory_product_tab%ROWTYPE )
IS
BEGIN
   Error_SYS.Record_Modified(Exm_Inventory_Product_API.lu_name_);
END Raise_Record_Modified___;


-- Raise_Record_Locked___
--    Raises error for: The database row is already locked.
PROCEDURE Raise_Record_Locked___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER )
IS
BEGIN
   Error_SYS.Record_Locked(Exm_Inventory_Product_API.lu_name_);
END Raise_Record_Locked___;


-- Raise_Record_Removed___
--    Raises error for: The database row is no longer present.
PROCEDURE Raise_Record_Removed___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER )
IS
BEGIN
   Error_SYS.Record_Removed(Exm_Inventory_Product_API.lu_name_);
END Raise_Record_Removed___;


-- Lock_By_Id___
--    Locks a database row based on the objid and objversion.
FUNCTION Lock_By_Id___ (
   objid_      IN VARCHAR2,
   objversion_ IN VARCHAR2 ) RETURN exm_inventory_product_tab%ROWTYPE
IS
   row_locked  EXCEPTION;
   PRAGMA      EXCEPTION_INIT(row_locked, -0054);
   rec_        exm_inventory_product_tab%ROWTYPE;
   dummy_      NUMBER;
BEGIN
   SELECT *
      INTO  rec_
      FROM  exm_inventory_product_tab
      WHERE rowid = objid_
      AND    to_char(rowversion,'YYYYMMDDHH24MISS') = objversion_
      FOR UPDATE NOWAIT;
   RETURN rec_;
EXCEPTION
   WHEN row_locked THEN
      Error_SYS.Record_Locked(lu_name_);
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(NULL, NULL, NULL, 'Lock_By_Id___');
   WHEN no_data_found THEN
      BEGIN
         SELECT 1
            INTO  dummy_
            FROM  exm_inventory_product_tab
            WHERE rowid = objid_;
         Raise_Record_Modified___(rec_);
      EXCEPTION
         WHEN no_data_found THEN
            Error_SYS.Record_Removed(lu_name_);
         WHEN too_many_rows THEN
            Raise_Too_Many_Rows___(NULL, NULL, NULL, 'Lock_By_Id___');
      END;
END Lock_By_Id___;


-- Lock_By_Keys___
--    Locks a database row based on the primary key values.
--    Waits until record released if locked by another session.
FUNCTION Lock_By_Keys___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER) RETURN exm_inventory_product_tab%ROWTYPE
IS
   row_locked  EXCEPTION;
   PRAGMA      EXCEPTION_INIT(row_locked, -0054);
   rec_        exm_inventory_product_tab%ROWTYPE;
BEGIN
   BEGIN
      SELECT *
         INTO  rec_
         FROM  exm_inventory_product_tab
         WHERE location_number = location_number_
         AND   inventory_id = inventory_id_
         AND   part_no = part_no_
         FOR UPDATE;
      RETURN rec_;
   EXCEPTION
      WHEN no_data_found THEN
         Raise_Record_Removed___(location_number_, inventory_id_, part_no_);
      WHEN too_many_rows THEN
         Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Lock_By_Keys___');
   END;
END Lock_By_Keys___;


-- Lock_By_Keys_Nowait___
--    Locks a database row based on the primary key values.
--    Raises exception if row already locked.
FUNCTION Lock_By_Keys_Nowait___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER) RETURN exm_inventory_product_tab%ROWTYPE
IS
   row_locked  EXCEPTION;
   PRAGMA      EXCEPTION_INIT(row_locked, -0054);
   rec_        exm_inventory_product_tab%ROWTYPE;
   dummy_      NUMBER;
BEGIN
   BEGIN
      SELECT *
         INTO  rec_
         FROM  exm_inventory_product_tab
         WHERE location_number = location_number_
         AND   inventory_id = inventory_id_
         AND   part_no = part_no_
         FOR UPDATE NOWAIT;
      RETURN rec_;
   EXCEPTION
      WHEN row_locked THEN
         Error_SYS.Record_Locked(lu_name_);
      WHEN too_many_rows THEN
         Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Lock_By_Keys___');
      WHEN no_data_found THEN
         BEGIN
            SELECT 1
               INTO  dummy_
               FROM  exm_inventory_product_tab
               WHERE location_number = location_number_
               AND   inventory_id = inventory_id_
               AND   part_no = part_no_;
            Raise_Record_Modified___(rec_);
         EXCEPTION
            WHEN no_data_found THEN
               Raise_Record_Removed___(location_number_, inventory_id_, part_no_);
            WHEN too_many_rows THEN
               Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Lock_By_Keys___');
         END;
   END;
END Lock_By_Keys_Nowait___;


-- Get_Object_By_Id___
--    Fetched a database row based on given the objid.
FUNCTION Get_Object_By_Id___ (
   objid_ IN VARCHAR2 ) RETURN exm_inventory_product_tab%ROWTYPE
IS
   lu_rec_ exm_inventory_product_tab%ROWTYPE;
BEGIN
   SELECT *
      INTO  lu_rec_
      FROM  exm_inventory_product_tab
      WHERE rowid = objid_;
   RETURN lu_rec_;
EXCEPTION
   WHEN no_data_found THEN
      Error_SYS.Record_Removed(lu_name_);
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(NULL, NULL, NULL, 'Get_Object_By_Id___');
END Get_Object_By_Id___;


-- Get_Object_By_Keys___
--    Fetched a database row based on given the primary key values.
@UncheckedAccess
FUNCTION Get_Object_By_Keys___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER ) RETURN exm_inventory_product_tab%ROWTYPE
IS
   lu_rec_ exm_inventory_product_tab%ROWTYPE;
BEGIN
   SELECT *
      INTO  lu_rec_
      FROM  exm_inventory_product_tab
      WHERE location_number = location_number_
      AND   inventory_id = inventory_id_
      AND   part_no = part_no_;
   RETURN lu_rec_;
EXCEPTION
   WHEN no_data_found THEN
      RETURN lu_rec_;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Get_Object_By_Keys___');
END Get_Object_By_Keys___;


-- Check_Exist___
--    Checks if a database row is already stored based on the primary key values.
@UncheckedAccess
FUNCTION Check_Exist___ (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER ) RETURN BOOLEAN
IS
   dummy_ NUMBER;
BEGIN
   SELECT 1
      INTO  dummy_
      FROM  exm_inventory_product_tab
      WHERE location_number = location_number_
      AND   inventory_id = inventory_id_
      AND   part_no = part_no_;
   RETURN TRUE;
EXCEPTION
   WHEN no_data_found THEN
      RETURN FALSE;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Check_Exist___');
END Check_Exist___;


-- Get_Version_By_Id___
--    Fetched the objversion for a database row based on the objid.
PROCEDURE Get_Version_By_Id___ (
   objid_      IN     VARCHAR2,
   objversion_ IN OUT VARCHAR2 )
IS
BEGIN
   SELECT to_char(rowversion,'YYYYMMDDHH24MISS')
      INTO  objversion_
      FROM  exm_inventory_product_tab
      WHERE rowid = objid_;
EXCEPTION
   WHEN no_data_found THEN
      objversion_ := NULL;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(NULL, NULL, NULL, 'Get_Version_By_Id___');
END Get_Version_By_Id___;


-- Get_Version_By_Keys___
--    Fetched the objversion for a database row based on the primary key.
PROCEDURE Get_Id_Version_By_Keys___ (
   objid_      IN OUT VARCHAR2,
   objversion_ IN OUT VARCHAR2,
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER )
IS
BEGIN
   SELECT rowid, to_char(rowversion,'YYYYMMDDHH24MISS')
      INTO  objid_, objversion_
      FROM  exm_inventory_product_tab
      WHERE location_number = location_number_
      AND   inventory_id = inventory_id_
      AND   part_no = part_no_;
EXCEPTION
   WHEN no_data_found THEN
      objid_      := NULL;
      objversion_ := NULL;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Get_Id_Version_By_Keys___');
END Get_Id_Version_By_Keys___;


-- Get_Key_By_Rowkey
--   Returns a table record with only keys (other attributes are NULL) based on a rowkey.
@UncheckedAccess
FUNCTION Get_Key_By_Rowkey (
   rowkey_ IN VARCHAR2 ) RETURN exm_inventory_product_tab%ROWTYPE
IS
   rec_ exm_inventory_product_tab%ROWTYPE;
BEGIN
   SELECT location_number, inventory_id, part_no
      INTO  rec_.location_number, rec_.inventory_id, rec_.part_no
      FROM  exm_inventory_product_tab
      WHERE rowkey = rowkey_;
   RETURN rec_;
EXCEPTION
   WHEN no_data_found THEN
      RETURN rec_;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(rec_.location_number, rec_.inventory_id, rec_.part_no, 'Get_Key_By_Rowkey');
END Get_Key_By_Rowkey;


-- Unpack___
--   Reads an attribute string and unpacks its contents into a record.
PROCEDURE Unpack___ (
   newrec_   IN OUT exm_inventory_product_tab%ROWTYPE,
   indrec_   IN OUT Indicator_Rec,
   attr_     IN OUT VARCHAR2 )
IS
   ptr_   NUMBER;
   name_  VARCHAR2(30);
   value_ VARCHAR2(32000);
   msg_   VARCHAR2(32000);
BEGIN
   Reset_Indicator_Rec___(indrec_);
   Client_SYS.Clear_Attr(msg_);
   ptr_ := NULL;
   WHILE (Client_SYS.Get_Next_From_Attr(attr_, ptr_, name_, value_)) LOOP
      CASE name_
      WHEN ('LOCATION_NUMBER') THEN
         newrec_.location_number := Client_SYS.Attr_Value_To_Number(value_);
         indrec_.location_number := TRUE;
      WHEN ('INVENTORY_ID') THEN
         newrec_.inventory_id := Client_SYS.Attr_Value_To_Number(value_);
         indrec_.inventory_id := TRUE;
      WHEN ('PART_NO') THEN
         newrec_.part_no := Client_SYS.Attr_Value_To_Number(value_);
         indrec_.part_no := TRUE;
      WHEN ('QUANTITY') THEN
         newrec_.quantity := Client_SYS.Attr_Value_To_Number(value_);
         indrec_.quantity := TRUE;
      ELSE
         Client_SYS.Add_To_Attr(name_, value_, msg_);
      END CASE;
   END LOOP;
   attr_ := msg_;
EXCEPTION
   WHEN value_error THEN
      Raise_Item_Format___(name_, value_);
END Unpack___;


-- Pack___
--   Reads a record and packs its contents into an attribute string.
--   This is intended to be the reverse of Unpack___
FUNCTION Pack___ (
   rec_ IN exm_inventory_product_tab%ROWTYPE ) RETURN VARCHAR2
IS
   attr_ VARCHAR2(32000);
BEGIN
   Client_SYS.Clear_Attr(attr_);
   IF (rec_.location_number IS NOT NULL) THEN
      Client_SYS.Add_To_Attr('LOCATION_NUMBER', rec_.location_number, attr_);
   END IF;
   IF (rec_.inventory_id IS NOT NULL) THEN
      Client_SYS.Add_To_Attr('INVENTORY_ID', rec_.inventory_id, attr_);
   END IF;
   IF (rec_.part_no IS NOT NULL) THEN
      Client_SYS.Add_To_Attr('PART_NO', rec_.part_no, attr_);
   END IF;
   IF (rec_.quantity IS NOT NULL) THEN
      Client_SYS.Add_To_Attr('QUANTITY', rec_.quantity, attr_);
   END IF;
   RETURN attr_;
END Pack___;


FUNCTION Pack___ (
   rec_ IN exm_inventory_product_tab%ROWTYPE,
   indrec_ IN Indicator_Rec ) RETURN VARCHAR2
IS
   attr_ VARCHAR2(32000);
BEGIN
   Client_SYS.Clear_Attr(attr_);
   IF (indrec_.location_number) THEN
      Client_SYS.Add_To_Attr('LOCATION_NUMBER', rec_.location_number, attr_);
   END IF;
   IF (indrec_.inventory_id) THEN
      Client_SYS.Add_To_Attr('INVENTORY_ID', rec_.inventory_id, attr_);
   END IF;
   IF (indrec_.part_no) THEN
      Client_SYS.Add_To_Attr('PART_NO', rec_.part_no, attr_);
   END IF;
   IF (indrec_.quantity) THEN
      Client_SYS.Add_To_Attr('QUANTITY', rec_.quantity, attr_);
   END IF;
   RETURN attr_;
END Pack___;



-- Pack_Table___
--   Reads a record and packs its contents into an attribute string.
--   Similar to Pack___ but just uses table column names and DB values
FUNCTION Pack_Table___ (
   rec_ IN exm_inventory_product_tab%ROWTYPE ) RETURN VARCHAR2
IS
   attr_ VARCHAR2(32000);
BEGIN
   Client_SYS.Clear_Attr(attr_);
   Client_SYS.Add_To_Attr('LOCATION_NUMBER', rec_.location_number, attr_);
   Client_SYS.Add_To_Attr('INVENTORY_ID', rec_.inventory_id, attr_);
   Client_SYS.Add_To_Attr('PART_NO', rec_.part_no, attr_);
   Client_SYS.Add_To_Attr('QUANTITY', rec_.quantity, attr_);
   Client_SYS.Add_To_Attr('ROWKEY', rec_.rowkey, attr_);
   RETURN attr_;
END Pack_Table___;


-- Reset_Indicator_Rec___
--   Resets all elements of given Indicator_Rec to FALSE.
PROCEDURE Reset_Indicator_Rec___ (
   indrec_ IN OUT Indicator_Rec )
IS
   empty_indrec_ Indicator_Rec;
BEGIN
   indrec_ := empty_indrec_;
END Reset_Indicator_Rec___;


-- Get_Indicator_Rec___
--   Returns an Indicator_Rec that reflects the content of a table record.
FUNCTION Get_Indicator_Rec___ (
   rec_ IN exm_inventory_product_tab%ROWTYPE ) RETURN Indicator_Rec
IS
   indrec_ Indicator_Rec;
BEGIN
   indrec_.location_number := rec_.location_number IS NOT NULL;
   indrec_.inventory_id := rec_.inventory_id IS NOT NULL;
   indrec_.part_no := rec_.part_no IS NOT NULL;
   indrec_.quantity := rec_.quantity IS NOT NULL;
   RETURN indrec_;
END Get_Indicator_Rec___;


-- Get_Indicator_Rec___
--   Returns an Indicator_Rec that reflects the difference between two table records.
FUNCTION Get_Indicator_Rec___ (
   oldrec_ IN exm_inventory_product_tab%ROWTYPE,
   newrec_ IN exm_inventory_product_tab%ROWTYPE ) RETURN Indicator_Rec
IS
   indrec_ Indicator_Rec;
BEGIN
   indrec_.location_number := Validate_SYS.Is_Changed(oldrec_.location_number, newrec_.location_number);
   indrec_.inventory_id := Validate_SYS.Is_Changed(oldrec_.inventory_id, newrec_.inventory_id);
   indrec_.part_no := Validate_SYS.Is_Changed(oldrec_.part_no, newrec_.part_no);
   indrec_.quantity := Validate_SYS.Is_Changed(oldrec_.quantity, newrec_.quantity);
   RETURN indrec_;
END Get_Indicator_Rec___;


-- Check_Common___
--   Perform validations on a record, that should be done for both insert and delete.
PROCEDURE Check_Common___ (
   oldrec_ IN     exm_inventory_product_tab%ROWTYPE,
   newrec_ IN OUT exm_inventory_product_tab%ROWTYPE,
   indrec_ IN OUT Indicator_Rec,
   attr_   IN OUT VARCHAR2 )
IS
BEGIN
   IF (newrec_.location_number IS NOT NULL AND newrec_.inventory_id IS NOT NULL)
   AND (indrec_.location_number OR indrec_.inventory_id)
   AND (Validate_SYS.Is_Changed(oldrec_.location_number, newrec_.location_number)
     OR Validate_SYS.Is_Changed(oldrec_.inventory_id, newrec_.inventory_id)) THEN
      Exm_Inventory_Location_API.Exist(newrec_.location_number, newrec_.inventory_id);
   END IF;
   IF (newrec_.part_no IS NOT NULL)
   AND (indrec_.part_no)
   AND (Validate_SYS.Is_Changed(oldrec_.part_no, newrec_.part_no)) THEN
      Exm_Part_API.Exist(newrec_.part_no);
   END IF;
   Error_SYS.Check_Not_Null(lu_name_, 'LOCATION_NUMBER', newrec_.location_number);
   Error_SYS.Check_Not_Null(lu_name_, 'INVENTORY_ID', newrec_.inventory_id);
   Error_SYS.Check_Not_Null(lu_name_, 'PART_NO', newrec_.part_no);
   Error_SYS.Check_Not_Null(lu_name_, 'QUANTITY', newrec_.quantity);
END Check_Common___;


-- Prepare_Insert___
--   Set client default values into an attribute string.
PROCEDURE Prepare_Insert___ (
   attr_ IN OUT VARCHAR2 )
IS
BEGIN
   Client_SYS.Clear_Attr(attr_);
END Prepare_Insert___;


-- Check_Insert___
--   Perform validations on a new record before it is insert.
PROCEDURE Check_Insert___ (
   newrec_ IN OUT exm_inventory_product_tab%ROWTYPE,
   indrec_ IN OUT Indicator_Rec,
   attr_   IN OUT VARCHAR2 )
IS
   oldrec_ exm_inventory_product_tab%ROWTYPE;
BEGIN
   Check_Common___(oldrec_, newrec_, indrec_, attr_);
END Check_Insert___;


-- Insert___
--   Insert a record to the database.
PROCEDURE Insert___ (
   objid_      OUT    VARCHAR2,
   objversion_ OUT    VARCHAR2,
   newrec_     IN OUT exm_inventory_product_tab%ROWTYPE,
   attr_       IN OUT VARCHAR2 )
IS
BEGIN
   newrec_.rowversion := sysdate;
   newrec_.rowkey := sys_guid();
   Client_SYS.Add_To_Attr('OBJKEY', newrec_.rowkey, attr_);
   INSERT
      INTO exm_inventory_product_tab
      VALUES newrec_
      RETURNING rowid INTO objid_;
   objversion_ := to_char(newrec_.rowversion,'YYYYMMDDHH24MISS');
EXCEPTION
   WHEN dup_val_on_index THEN
      DECLARE
         constraint_ VARCHAR2(4000) := Utility_SYS.Between_Str(Utility_SYS.Between_Str(sqlerrm, '(', ')'), '.', ')', 'FALSE');
      BEGIN
         IF (constraint_ = 'EXM_INVENTORY_PRODUCT_RK') THEN
            Error_SYS.Rowkey_Exist(lu_name_, newrec_.rowkey);
         ELSE
            Raise_Record_Exist___(newrec_);
         END IF;
      END;
END Insert___;


-- Prepare_New___
--    Set default values for a table record.
PROCEDURE Prepare_New___ (
   newrec_ IN OUT exm_inventory_product_tab%ROWTYPE )
IS
   attr_    VARCHAR2(32000);
   indrec_  Indicator_Rec;
BEGIN
   Prepare_Insert___(attr_);
   Unpack___(newrec_, indrec_, attr_);
END Prepare_New___;


-- New___
--    Checks and creates a new record.
PROCEDURE New___ (
   newrec_ IN OUT exm_inventory_product_tab%ROWTYPE )
IS
   objid_         VARCHAR2(20);
   objversion_    VARCHAR2(100);
   attr_          VARCHAR2(32000);
   indrec_        Indicator_Rec;
   emptyrec_      exm_inventory_product_tab%ROWTYPE;
BEGIN
   indrec_ := Get_Indicator_Rec___(emptyrec_, newrec_);
   Check_Insert___(newrec_, indrec_, attr_);
   Insert___(objid_, objversion_, newrec_, attr_);
END New___;


-- Check_Update___
--   Perform validations on a new record before it is updated.
PROCEDURE Check_Update___ (
   oldrec_ IN     exm_inventory_product_tab%ROWTYPE,
   newrec_ IN OUT exm_inventory_product_tab%ROWTYPE,
   indrec_ IN OUT Indicator_Rec,
   attr_   IN OUT VARCHAR2 )
IS
BEGIN
   Validate_SYS.Item_Update(lu_name_, 'LOCATION_NUMBER', indrec_.location_number);
   Validate_SYS.Item_Update(lu_name_, 'INVENTORY_ID', indrec_.inventory_id);
   Validate_SYS.Item_Update(lu_name_, 'PART_NO', indrec_.part_no);
   Check_Common___(oldrec_, newrec_, indrec_, attr_);
END Check_Update___;


-- Update___
--   Update a record in database with new data.
PROCEDURE Update___ (
   objid_      IN     VARCHAR2,
   oldrec_     IN     exm_inventory_product_tab%ROWTYPE,
   newrec_     IN OUT exm_inventory_product_tab%ROWTYPE,
   attr_       IN OUT VARCHAR2,
   objversion_ IN OUT VARCHAR2,
   by_keys_    IN     BOOLEAN DEFAULT FALSE )
IS
BEGIN
   newrec_.rowversion := sysdate;
   IF by_keys_ THEN
      UPDATE exm_inventory_product_tab
         SET ROW = newrec_
         WHERE location_number = newrec_.location_number
         AND   inventory_id = newrec_.inventory_id
         AND   part_no = newrec_.part_no;
   ELSE
      UPDATE exm_inventory_product_tab
         SET ROW = newrec_
         WHERE rowid = objid_;
   END IF;
   objversion_ := to_char(newrec_.rowversion,'YYYYMMDDHH24MISS');
EXCEPTION
   WHEN dup_val_on_index THEN
      DECLARE
         constraint_ VARCHAR2(4000) := Utility_SYS.Between_Str(Utility_SYS.Between_Str(sqlerrm, '(', ')'), '.', ')', 'FALSE');
      BEGIN
         IF (constraint_ = 'EXM_INVENTORY_PRODUCT_RK') THEN
            Error_SYS.Rowkey_Exist(Exm_Inventory_Product_API.lu_name_, newrec_.rowkey);
         ELSE
            Raise_Record_Exist___(newrec_);
         END IF;
      END;
END Update___;


-- Modify___
--    Modifies an existing instance of the logical unit.
PROCEDURE Modify___ (
   newrec_         IN OUT exm_inventory_product_tab%ROWTYPE,
   lock_mode_wait_ IN     BOOLEAN DEFAULT TRUE )
IS
   objid_      VARCHAR2(20);
   objversion_ VARCHAR2(100);
   attr_       VARCHAR2(32000);
   indrec_     Indicator_rec;
   oldrec_     exm_inventory_product_tab%ROWTYPE;
BEGIN
   IF (lock_mode_wait_) THEN
      oldrec_ := Lock_By_Keys___(newrec_.location_number, newrec_.inventory_id, newrec_.part_no);
   ELSE
      oldrec_ := Lock_By_Keys_Nowait___(newrec_.location_number, newrec_.inventory_id, newrec_.part_no);
   END IF;
   indrec_ := Get_Indicator_Rec___(oldrec_, newrec_);
   Check_Update___(oldrec_, newrec_, indrec_, attr_);
   Update___(objid_, oldrec_, newrec_, attr_, objversion_, TRUE);
END Modify___;


-- Check_Delete___
--   Perform validations on a new record before it is deleted.
PROCEDURE Check_Delete___ (
   remrec_ IN exm_inventory_product_tab%ROWTYPE )
IS
   key_ VARCHAR2(2000);
BEGIN
   key_ := remrec_.location_number||'^'||remrec_.inventory_id||'^'||remrec_.part_no||'^';
   Reference_SYS.Check_Restricted_Delete(lu_name_, key_);
END Check_Delete___;


-- Delete___
--   Delete a record from the database.
PROCEDURE Delete___ (
   objid_  IN VARCHAR2,
   remrec_ IN exm_inventory_product_tab%ROWTYPE )
IS
   key_ VARCHAR2(2000);
BEGIN
   key_ := remrec_.location_number||'^'||remrec_.inventory_id||'^'||remrec_.part_no||'^';
   Reference_SYS.Do_Cascade_Delete(lu_name_, key_);
   IF (objid_ IS NOT NULL) THEN
      DELETE
         FROM  exm_inventory_product_tab
         WHERE rowid = objid_;
   ELSE
      DELETE
         FROM  exm_inventory_product_tab
         WHERE location_number = remrec_.location_number
         AND   inventory_id = remrec_.inventory_id
         AND   part_no = remrec_.part_no;
   END IF;
END Delete___;


-- Delete___
--   Delete a record from the database.
@Deprecated
PROCEDURE Delete___ (
   remrec_ IN exm_inventory_product_tab%ROWTYPE )
IS
BEGIN
   Delete___(NULL, remrec_);
END Delete___;


-- Remove___
--    Removes an existing instance of the logical unit.
PROCEDURE Remove___ (
   remrec_         IN OUT exm_inventory_product_tab%ROWTYPE,
   lock_mode_wait_ IN     BOOLEAN DEFAULT TRUE )
IS
   oldrec_     exm_inventory_product_tab%ROWTYPE;
BEGIN
   IF (lock_mode_wait_) THEN
      oldrec_ := Lock_By_Keys___(remrec_.location_number, remrec_.inventory_id, remrec_.part_no);
   ELSE
      oldrec_ := Lock_By_Keys_Nowait___(remrec_.location_number, remrec_.inventory_id, remrec_.part_no);
   END IF;
   Check_Delete___(oldrec_);
   Delete___(NULL, oldrec_);
END Remove___;


-- Lock__
--    Client-support to lock a specific instance of the logical unit.
@UncheckedAccess
PROCEDURE Lock__ (
   info_       OUT VARCHAR2,
   objid_      IN  VARCHAR2,
   objversion_ IN  VARCHAR2 )
IS
   dummy_ exm_inventory_product_tab%ROWTYPE;
BEGIN
   dummy_ := Lock_By_Id___(objid_, objversion_);
   info_ := Client_SYS.Get_All_Info;
END Lock__;


-- New__
--    Client-support interface to create LU instances.
--       action_ = 'PREPARE'
--          Default values and handle of information to client.
--          The default values are set in procedure Prepare_Insert___.
--       action_ = 'CHECK'
--          Check all attributes before creating new object and handle of
--          information to client. The attribute list is unpacked, checked
--          and prepared (defaults) in procedures Unpack___ and Check_Insert___.
--       action_ = 'DO'
--          Creation of new instances of the logical unit and handle of
--          information to client. The attribute list is unpacked, checked
--          and prepared (defaults) in procedures Unpack___ and Check_Insert___
--          before calling procedure Insert___.
PROCEDURE New__ (
   info_       OUT    VARCHAR2,
   objid_      OUT    VARCHAR2,
   objversion_ OUT    VARCHAR2,
   attr_       IN OUT VARCHAR2,
   action_     IN     VARCHAR2 )
IS
   newrec_   exm_inventory_product_tab%ROWTYPE;
   indrec_   Indicator_Rec;
BEGIN
   IF (action_ = 'PREPARE') THEN
      Prepare_Insert___(attr_);
   ELSIF (action_ = 'CHECK') THEN
      Unpack___(newrec_, indrec_, attr_);
      Check_Insert___(newrec_, indrec_, attr_);
   ELSIF (action_ = 'DO') THEN
      Unpack___(newrec_, indrec_, attr_);
      Check_Insert___(newrec_, indrec_, attr_);
      Insert___(objid_, objversion_, newrec_, attr_);
   END IF;
   info_ := Client_SYS.Get_All_Info;
END New__;


-- Modify__
--    Client-support interface to modify attributes for LU instances.
--       action_ = 'CHECK'
--          Check all attributes before modifying an existing object and
--          handle of information to client. The attribute list is unpacked,
--          checked and prepared(defaults) in procedures Unpack___ and Check_Update___.
--       action_ = 'DO'
--          Modification of an existing instance of the logical unit. The
--          procedure unpacks the attributes, checks all values before
--          procedure Update___ is called.
PROCEDURE Modify__ (
   info_       OUT    VARCHAR2,
   objid_      IN     VARCHAR2,
   objversion_ IN OUT VARCHAR2,
   attr_       IN OUT VARCHAR2,
   action_     IN     VARCHAR2 )
IS
   oldrec_   exm_inventory_product_tab%ROWTYPE;
   newrec_   exm_inventory_product_tab%ROWTYPE;
   indrec_   Indicator_Rec;
BEGIN
   IF (action_ = 'CHECK') THEN
      oldrec_ := Get_Object_By_Id___(objid_);
      newrec_ := oldrec_;
      Unpack___(newrec_, indrec_, attr_);
      Check_Update___(oldrec_, newrec_, indrec_, attr_);
   ELSIF (action_ = 'DO') THEN
      oldrec_ := Lock_By_Id___(objid_, objversion_);
      newrec_ := oldrec_;
      Unpack___(newrec_, indrec_, attr_);
      Check_Update___(oldrec_, newrec_, indrec_, attr_);
      Update___(objid_, oldrec_, newrec_, attr_, objversion_);
   END IF;
   info_ := Client_SYS.Get_All_Info;
END Modify__;


-- Remove__
--    Client-support interface to remove LU instances.
--       action_ = 'CHECK'
--          Check whether a specific LU-instance may be removed or not.
--          The procedure fetches the complete record by calling procedure
--          Get_Object_By_Id___. Then the check is made by calling procedure
--          Check_Delete___.
--       action_ = 'DO'
--          Remove an existing instance of the logical unit. The procedure
--          fetches the complete LU-record, checks for a delete and then
--          deletes the record by calling procedure Delete___.
PROCEDURE Remove__ (
   info_       OUT VARCHAR2,
   objid_      IN  VARCHAR2,
   objversion_ IN  VARCHAR2,
   action_     IN  VARCHAR2 )
IS
   remrec_ exm_inventory_product_tab%ROWTYPE;
BEGIN
   IF (action_ = 'CHECK') THEN
      remrec_ := Get_Object_By_Id___(objid_);
      Check_Delete___(remrec_);
   ELSIF (action_ = 'DO') THEN
      remrec_ := Lock_By_Id___(objid_, objversion_);
      Check_Delete___(remrec_);
      Delete___(objid_, remrec_);
   END IF;
   info_ := Client_SYS.Get_All_Info;
END Remove__;


-- Exist
--   Checks if given pointer (e.g. primary key) to an instance of this
--   logical unit exists. If not an exception will be raised.
@UncheckedAccess
PROCEDURE Exist (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER )
IS
BEGIN
   IF (NOT Check_Exist___(location_number_, inventory_id_, part_no_)) THEN
      Raise_Record_Not_Exist___(location_number_, inventory_id_, part_no_);
   END IF;
END Exist;


-- Exists
--   Same check as Exist, but returns a BOOLEAN value instead of exception.
@UncheckedAccess
FUNCTION Exists (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER ) RETURN BOOLEAN
IS
BEGIN
   RETURN Check_Exist___(location_number_, inventory_id_, part_no_);
END Exists;


-- Get_Quantity
--   Fetches the Quantity attribute for a record.
@UncheckedAccess
FUNCTION Get_Quantity (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER ) RETURN NUMBER
IS
   temp_ exm_inventory_product_tab.quantity%TYPE;
BEGIN
   IF (location_number_ IS NULL OR inventory_id_ IS NULL OR part_no_ IS NULL) THEN
      RETURN NULL;
   END IF;
   SELECT quantity
      INTO  temp_
      FROM  exm_inventory_product_tab
      WHERE location_number = location_number_
      AND   inventory_id = inventory_id_
      AND   part_no = part_no_;
   RETURN temp_;
EXCEPTION
   WHEN no_data_found THEN
      RETURN NULL;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Get_Quantity');
END Get_Quantity;


-- Get
--   Fetches a record containing the public attributes.
@UncheckedAccess
FUNCTION Get (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER ) RETURN Public_Rec
IS
   temp_ Public_Rec;
BEGIN
   IF (location_number_ IS NULL OR inventory_id_ IS NULL OR part_no_ IS NULL) THEN
      RETURN NULL;
   END IF;
   SELECT location_number, inventory_id, part_no,
          rowid, rowversion, rowkey,
          quantity
      INTO  temp_
      FROM  exm_inventory_product_tab
      WHERE location_number = location_number_
      AND   inventory_id = inventory_id_
      AND   part_no = part_no_;
   RETURN temp_;
EXCEPTION
   WHEN no_data_found THEN
      RETURN NULL;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Get');
END Get;


-- Get_Objkey
--   Fetches the objkey attribute for a record.
@UncheckedAccess
FUNCTION Get_Objkey (
   location_number_ IN NUMBER,
   inventory_id_ IN NUMBER,
   part_no_ IN NUMBER ) RETURN VARCHAR2
IS
   rowkey_ exm_inventory_product_tab.rowkey%TYPE;
BEGIN
   IF (location_number_ IS NULL OR inventory_id_ IS NULL OR part_no_ IS NULL) THEN
      RETURN NULL;
   END IF;
   SELECT rowkey
      INTO  rowkey_
      FROM  exm_inventory_product_tab
      WHERE location_number = location_number_
      AND   inventory_id = inventory_id_
      AND   part_no = part_no_;
   RETURN rowkey_;
EXCEPTION
   WHEN no_data_found THEN
      RETURN NULL;
   WHEN too_many_rows THEN
      Raise_Too_Many_Rows___(location_number_, inventory_id_, part_no_, 'Get_Objkey');
END Get_Objkey;

-------------------- FOUNDATION1 METHODS ------------------------------------


-- Init
--   Framework method that initializes this package.
@UncheckedAccess
PROCEDURE Init
IS
BEGIN
   NULL;
END Init;

