//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Entity.Core.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets32CD194B04BDC9F607C67C8FAB6BC4DC))]

namespace Edm_EntityMappingGeneratedViews
{

    /// <Summary>
    /// The type contains views for EntitySets and AssociationSets that were generated at design time.
    /// </Summary>
    public sealed class ViewsForBaseEntitySets32CD194B04BDC9F607C67C8FAB6BC4DC : System.Data.Entity.Core.Mapping.EntityViewContainer
    {

        /// <Summary>
        /// The constructor stores the views for the extents and also the hash values generated based on the metadata and mapping closure and views
        /// </Summary>
        public ViewsForBaseEntitySets32CD194B04BDC9F607C67C8FAB6BC4DC()
        {
            this.EdmEntityContainerName = "XmlTestContext";
            this.StoreEntityContainerName = "XmlTestStoreContainer";
            this.HashOverMappingClosure = "f1b01cb63d8b711866cfe7ecbfa9367e";
            this.HashOverAllExtentViews = "b0c3118d79b4c037f19c708219fdab28";
            this.ViewCount = 19;
        }

        // The method returns the view for the index given.
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                // return view for XmlTestStoreContainer.Customer
                return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.Customer", "\r\n    SELECT VALUE -- Constructing Customer\r\n        [XmlTest.Store].Customer(T1." +
                        "Customer_OrderID, T1.Customer_NameStyle, T1.Customer_FirstName, T1.Customer_Last" +
                        "Name, T1.Customer_Active, T1.Customer_ModifiedDate, T1.Customer_TourNumber, T1.C" +
                        "ustomer_ExternalNumber, T1.Customer_MainPhone1, T1.Customer_MainPhone2, T1.Custo" +
                        "mer_PreOrderID, T1.Customer_LastVisit, T1.Customer_Created, T1.Customer_External" +
                        "Name, T1.Customer_NewCustomer, T1.Customer_Potential, T1.Customer_CustomerID, T1" +
                        ".Customer_OldExternalNumber, T1.Customer_OldTourNumber, T1.Customer_NewAssigned," +
                        " T1.Customer_OldActive, T1.Customer_StartDate, T1.Customer_Total)\r\n    FROM (\r\n " +
                        "       SELECT \r\n            T.OrderID AS Customer_OrderID, \r\n            T.NameS" +
                        "tyle AS Customer_NameStyle, \r\n            T.FirstName AS Customer_FirstName, \r\n " +
                        "           T.LastName AS Customer_LastName, \r\n            T.Active AS Customer_A" +
                        "ctive, \r\n            T.ModifiedDate AS Customer_ModifiedDate, \r\n            T.To" +
                        "urNumber AS Customer_TourNumber, \r\n            T.ExternalNumber AS Customer_Exte" +
                        "rnalNumber, \r\n            T.MainPhone1 AS Customer_MainPhone1, \r\n            T.M" +
                        "ainPhone2 AS Customer_MainPhone2, \r\n            T.PreOrderID AS Customer_PreOrde" +
                        "rID, \r\n            T.LastVisit AS Customer_LastVisit, \r\n            T.Created AS" +
                        " Customer_Created, \r\n            T.ExternalName AS Customer_ExternalName, \r\n    " +
                        "        T.NewCustomer AS Customer_NewCustomer, \r\n            T.Potential AS Cust" +
                        "omer_Potential, \r\n            T.CustomerID AS Customer_CustomerID, \r\n           " +
                        " T.OldExternalNumber AS Customer_OldExternalNumber, \r\n            T.OldTourNumbe" +
                        "r AS Customer_OldTourNumber, \r\n            T.NewAssigned AS Customer_NewAssigned" +
                        ", \r\n            T.OldActive AS Customer_OldActive, \r\n            T.StartDate AS " +
                        "Customer_StartDate, \r\n            T.Total AS Customer_Total, \r\n            True " +
                        "AS _from0\r\n        FROM XmlTestContext.Customer AS T\r\n    ) AS T1");
            }
            else
            {
                if ((index == 1))
                {
                    // return view for XmlTestStoreContainer.SalesOrderHeader
                    return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.SalesOrderHeader", "\r\n    SELECT VALUE -- Constructing SalesOrderHeader\r\n        [XmlTest.Store].Sale" +
                            "sOrderHeader(T3.SalesOrderHeader_OrderDate, T3.SalesOrderHeader_Status, T3.Sales" +
                            "OrderHeader_BillToAddressID, T3.SalesOrderHeader_SubTotal, T3.SalesOrderHeader_T" +
                            "otalDue, T3.SalesOrderHeader_Comment, T3.SalesOrderHeader_ModifiedDate, T3.Sales" +
                            "OrderHeader_PaymentVersion, T3.SalesOrderHeader_BillID, T3.SalesOrderHeader_Book" +
                            "Counter, T3.SalesOrderHeader_SendID, T3.SalesOrderHeader_SubSubTotal, T3.SalesOr" +
                            "derHeader_PriceRabatt15, T3.SalesOrderHeader_Total, T3.SalesOrderHeader_Discount" +
                            ", T3.SalesOrderHeader_Rabatt, T3.SalesOrderHeader_OrderID, T3.SalesOrderHeader_S" +
                            "endDate, T3.SalesOrderHeader_ID, T3.SalesOrderHeader_Saison)\r\n    FROM (\r\n      " +
                            "  SELECT T2.SalesOrderHeader_OrderDate, T2.SalesOrderHeader_Status, T2.SalesOrde" +
                            "rHeader_BillToAddressID, T2.SalesOrderHeader_SubTotal, T2.SalesOrderHeader_Total" +
                            "Due, T2.SalesOrderHeader_Comment, T2.SalesOrderHeader_ModifiedDate, T2.SalesOrde" +
                            "rHeader_PaymentVersion, T2.SalesOrderHeader_BillID, T2.SalesOrderHeader_BookCoun" +
                            "ter, T2.SalesOrderHeader_SendID, T2.SalesOrderHeader_SubSubTotal, T2.SalesOrderH" +
                            "eader_PriceRabatt15, T2.SalesOrderHeader_Total, T2.SalesOrderHeader_Discount, T2" +
                            ".SalesOrderHeader_Rabatt, T1.SalesOrderHeader_OrderID, T2.SalesOrderHeader_SendD" +
                            "ate, T1.SalesOrderHeader_ID, T2.SalesOrderHeader_Saison, T2._from0, T1._from1\r\n " +
                            "       FROM  (\r\n            SELECT \r\n                Key(T.Customer).OrderID AS " +
                            "SalesOrderHeader_OrderID, \r\n                Key(T.SalesOrderHeader).ID AS SalesO" +
                            "rderHeader_ID, \r\n                True AS _from1\r\n            FROM XmlTestContext" +
                            ".SalesOrderHeader_OrderID_fkey AS T) AS T1\r\n            INNER JOIN (\r\n          " +
                            "  SELECT \r\n                T.OrderDate AS SalesOrderHeader_OrderDate, \r\n        " +
                            "        T.Status AS SalesOrderHeader_Status, \r\n                T.BillToAddressID" +
                            " AS SalesOrderHeader_BillToAddressID, \r\n                T.SubTotal AS SalesOrder" +
                            "Header_SubTotal, \r\n                T.TotalDue AS SalesOrderHeader_TotalDue, \r\n  " +
                            "              T.Comment AS SalesOrderHeader_Comment, \r\n                T.Modifie" +
                            "dDate AS SalesOrderHeader_ModifiedDate, \r\n                T.PaymentVersion AS Sa" +
                            "lesOrderHeader_PaymentVersion, \r\n                T.BillID AS SalesOrderHeader_Bi" +
                            "llID, \r\n                T.BookCounter AS SalesOrderHeader_BookCounter, \r\n       " +
                            "         T.SendID AS SalesOrderHeader_SendID, \r\n                T.SubSubTotal AS" +
                            " SalesOrderHeader_SubSubTotal, \r\n                T.PriceRabatt15 AS SalesOrderHe" +
                            "ader_PriceRabatt15, \r\n                T.Total AS SalesOrderHeader_Total, \r\n     " +
                            "           T.Discount AS SalesOrderHeader_Discount, \r\n                T.Rabatt A" +
                            "S SalesOrderHeader_Rabatt, \r\n                T.SendDate AS SalesOrderHeader_Send" +
                            "Date, \r\n                T.ID AS SalesOrderHeader_ID, \r\n                T.Saison " +
                            "AS SalesOrderHeader_Saison, \r\n                True AS _from0\r\n            FROM X" +
                            "mlTestContext.SalesOrderHeader AS T) AS T2\r\n            ON T1.SalesOrderHeader_I" +
                            "D = T2.SalesOrderHeader_ID\r\n    ) AS T3");
                }
                else
                {
                    if ((index == 2))
                    {
                        // return view for XmlTestContext.Customer
                        return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.Customer", "\r\n    SELECT VALUE -- Constructing Customer\r\n        XmlTest.Customer(T1.Customer" +
                                "_OrderID, T1.Customer_NameStyle, T1.Customer_FirstName, T1.Customer_LastName, T1" +
                                ".Customer_Active, T1.Customer_ModifiedDate, T1.Customer_TourNumber, T1.Customer_" +
                                "ExternalNumber, T1.Customer_MainPhone1, T1.Customer_MainPhone2, T1.Customer_PreO" +
                                "rderID, T1.Customer_LastVisit, T1.Customer_Created, T1.Customer_ExternalName, T1" +
                                ".Customer_NewCustomer, T1.Customer_Potential, T1.Customer_CustomerID, T1.Custome" +
                                "r_OldExternalNumber, T1.Customer_OldTourNumber, T1.Customer_NewAssigned, T1.Cust" +
                                "omer_OldActive, T1.Customer_StartDate, T1.Customer_Total)\r\n    FROM (\r\n        S" +
                                "ELECT \r\n            T.OrderID AS Customer_OrderID, \r\n            T.NameStyle AS " +
                                "Customer_NameStyle, \r\n            T.FirstName AS Customer_FirstName, \r\n         " +
                                "   T.LastName AS Customer_LastName, \r\n            T.Active AS Customer_Active, \r" +
                                "\n            T.ModifiedDate AS Customer_ModifiedDate, \r\n            T.TourNumber" +
                                " AS Customer_TourNumber, \r\n            T.ExternalNumber AS Customer_ExternalNumb" +
                                "er, \r\n            T.MainPhone1 AS Customer_MainPhone1, \r\n            T.MainPhone" +
                                "2 AS Customer_MainPhone2, \r\n            T.PreOrderID AS Customer_PreOrderID, \r\n " +
                                "           T.LastVisit AS Customer_LastVisit, \r\n            T.Created AS Custome" +
                                "r_Created, \r\n            T.ExternalName AS Customer_ExternalName, \r\n            " +
                                "T.NewCustomer AS Customer_NewCustomer, \r\n            T.Potential AS Customer_Pot" +
                                "ential, \r\n            T.CustomerID AS Customer_CustomerID, \r\n            T.OldEx" +
                                "ternalNumber AS Customer_OldExternalNumber, \r\n            T.OldTourNumber AS Cus" +
                                "tomer_OldTourNumber, \r\n            T.NewAssigned AS Customer_NewAssigned, \r\n    " +
                                "        T.OldActive AS Customer_OldActive, \r\n            T.StartDate AS Customer" +
                                "_StartDate, \r\n            T.Total AS Customer_Total, \r\n            True AS _from" +
                                "0\r\n        FROM XmlTestStoreContainer.Customer AS T\r\n    ) AS T1");
                    }
                    else
                    {
                        if ((index == 3))
                        {
                            // return view for XmlTestContext.SalesOrderHeader
                            return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.SalesOrderHeader", "\r\n    SELECT VALUE -- Constructing SalesOrderHeader\r\n        XmlTest.SalesOrderHe" +
                                    "ader(T1.SalesOrderHeader_OrderDate, T1.SalesOrderHeader_Status, T1.SalesOrderHea" +
                                    "der_BillToAddressID, T1.SalesOrderHeader_SubTotal, T1.SalesOrderHeader_TotalDue," +
                                    " T1.SalesOrderHeader_Comment, T1.SalesOrderHeader_ModifiedDate, T1.SalesOrderHea" +
                                    "der_PaymentVersion, T1.SalesOrderHeader_BillID, T1.SalesOrderHeader_BookCounter," +
                                    " T1.SalesOrderHeader_SendID, T1.SalesOrderHeader_SubSubTotal, T1.SalesOrderHeade" +
                                    "r_PriceRabatt15, T1.SalesOrderHeader_Total, T1.SalesOrderHeader_Discount, T1.Sal" +
                                    "esOrderHeader_Rabatt, T1.SalesOrderHeader_SendDate, T1.SalesOrderHeader_ID, T1.S" +
                                    "alesOrderHeader_Saison) WITH \r\n        RELATIONSHIP(CREATEREF(XmlTestContext.Cus" +
                                    "tomer, ROW(T1.[SalesOrderHeader_OrderID_fkey.Customer.OrderID]),XmlTest.Customer" +
                                    "),XmlTest.SalesOrderHeader_OrderID_fkey,SalesOrderHeader,Customer) \r\n    FROM (\r" +
                                    "\n        SELECT \r\n            T.OrderDate AS SalesOrderHeader_OrderDate, \r\n     " +
                                    "       T.Status AS SalesOrderHeader_Status, \r\n            T.BillToAddressID AS S" +
                                    "alesOrderHeader_BillToAddressID, \r\n            T.SubTotal AS SalesOrderHeader_Su" +
                                    "bTotal, \r\n            T.TotalDue AS SalesOrderHeader_TotalDue, \r\n            T.C" +
                                    "omment AS SalesOrderHeader_Comment, \r\n            T.ModifiedDate AS SalesOrderHe" +
                                    "ader_ModifiedDate, \r\n            T.PaymentVersion AS SalesOrderHeader_PaymentVer" +
                                    "sion, \r\n            T.BillID AS SalesOrderHeader_BillID, \r\n            T.BookCou" +
                                    "nter AS SalesOrderHeader_BookCounter, \r\n            T.SendID AS SalesOrderHeader" +
                                    "_SendID, \r\n            T.SubSubTotal AS SalesOrderHeader_SubSubTotal, \r\n        " +
                                    "    T.PriceRabatt15 AS SalesOrderHeader_PriceRabatt15, \r\n            T.Total AS " +
                                    "SalesOrderHeader_Total, \r\n            T.Discount AS SalesOrderHeader_Discount, \r" +
                                    "\n            T.Rabatt AS SalesOrderHeader_Rabatt, \r\n            T.SendDate AS Sa" +
                                    "lesOrderHeader_SendDate, \r\n            T.ID AS SalesOrderHeader_ID, \r\n          " +
                                    "  T.Saison AS SalesOrderHeader_Saison, \r\n            True AS _from0, \r\n         " +
                                    "   T.OrderID AS [SalesOrderHeader_OrderID_fkey.Customer.OrderID]\r\n        FROM X" +
                                    "mlTestStoreContainer.SalesOrderHeader AS T\r\n    ) AS T1");
                        }
                        else
                        {
                            if ((index == 4))
                            {
                                // return view for XmlTestContext.SalesOrderHeader_OrderID_fkey
                                return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.SalesOrderHeader_OrderID_fkey", @"
    SELECT VALUE -- Constructing SalesOrderHeader_OrderID_fkey
        XmlTest.SalesOrderHeader_OrderID_fkey(T3.[SalesOrderHeader_OrderID_fkey.Customer], T3.[SalesOrderHeader_OrderID_fkey.SalesOrderHeader])
    FROM (
        SELECT -- Constructing Customer
            CreateRef(XmlTestContext.Customer, row(T2.[SalesOrderHeader_OrderID_fkey.Customer.OrderID]),XmlTest.Customer) AS [SalesOrderHeader_OrderID_fkey.Customer],
            T2.[SalesOrderHeader_OrderID_fkey.SalesOrderHeader]
        FROM (
            SELECT -- Constructing SalesOrderHeader
                CreateRef(XmlTestContext.SalesOrderHeader, row(T1.[SalesOrderHeader_OrderID_fkey.SalesOrderHeader.ID]),XmlTest.SalesOrderHeader) AS [SalesOrderHeader_OrderID_fkey.SalesOrderHeader],
                T1.[SalesOrderHeader_OrderID_fkey.Customer.OrderID]
            FROM (
                SELECT
                    T.OrderID AS [SalesOrderHeader_OrderID_fkey.Customer.OrderID],
                    T.ID AS [SalesOrderHeader_OrderID_fkey.SalesOrderHeader.ID],
                    True AS _from0
                FROM XmlTestStoreContainer.SalesOrderHeader AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                            }
                            else
                            {
                                if ((index == 5))
                                {
                                    // return view for XmlTestStoreContainer.User
                                    return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.User", @"
    SELECT VALUE -- Constructing User
        [XmlTest.Store].User(T1.User_UserId, T1.User_Name, T1.User_Login, T1.User_StatusId)
    FROM (
        SELECT
            T.UserId AS User_UserId,
            T.Name AS User_Name,
            T.Login AS User_Login,
            T.StatusId AS User_StatusId,
            True AS _from0
        FROM XmlTestContext.User AS T
    ) AS T1");
                                }
                                else
                                {
                                    if ((index == 6))
                                    {
                                        // return view for XmlTestStoreContainer.UserDetails
                                        return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.UserDetails", @"
    SELECT VALUE -- Constructing UserDetails
        [XmlTest.Store].UserDetails(T1.UserDetails_UserId, T1.UserDetails_Details)
    FROM (
        SELECT
            T.UserId AS UserDetails_UserId,
            T.Details AS UserDetails_Details,
            True AS _from0
        FROM XmlTestContext.UserDetails AS T
    ) AS T1");
                                    }
                                    else
                                    {
                                        if ((index == 7))
                                        {
                                            // return view for XmlTestStoreContainer.UserToken
                                            return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.UserToken", @"
    SELECT VALUE -- Constructing UserToken
        [XmlTest.Store].UserToken(T1.UserToken_UserId, T1.UserToken_Token)
    FROM (
        SELECT
            T.UserId AS UserToken_UserId,
            T.Token AS UserToken_Token,
            True AS _from0
        FROM XmlTestContext.UserToken AS T
    ) AS T1");
                                        }
                                        else
                                        {
                                            if ((index == 8))
                                            {
                                                // return view for XmlTestContext.User
                                                return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.User", @"
    SELECT VALUE -- Constructing User
        XmlTest.User(T1.User_UserId, T1.User_Name, T1.User_Login, T1.User_StatusId)
    FROM (
        SELECT
            T.UserId AS User_UserId,
            T.Name AS User_Name,
            T.Login AS User_Login,
            T.StatusId AS User_StatusId,
            True AS _from0
        FROM XmlTestStoreContainer.User AS T
    ) AS T1");
                                            }
                                            else
                                            {
                                                if ((index == 9))
                                                {
                                                    // return view for XmlTestContext.UserDetails
                                                    return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.UserDetails", @"
    SELECT VALUE -- Constructing UserDetails
        XmlTest.UserDetails(T1.UserDetails_UserId, T1.UserDetails_Details)
    FROM (
        SELECT
            T.UserId AS UserDetails_UserId,
            T.Details AS UserDetails_Details,
            True AS _from0,
            T.UserId AS [UserDetails_FK.UserDetails.UserId]
        FROM XmlTestStoreContainer.UserDetails AS T
    ) AS T1");
                                                }
                                                else
                                                {
                                                    if ((index == 10))
                                                    {
                                                        // return view for XmlTestContext.UserToken
                                                        return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.UserToken", @"
    SELECT VALUE -- Constructing UserToken
        XmlTest.UserToken(T1.UserToken_UserId, T1.UserToken_Token)
    FROM (
        SELECT
            T.UserId AS UserToken_UserId,
            T.Token AS UserToken_Token,
            True AS _from0,
            T.UserId AS [UserToken_FK.UserToken.UserId]
        FROM XmlTestStoreContainer.UserToken AS T
    ) AS T1");
                                                    }
                                                    else
                                                    {
                                                        if ((index == 11))
                                                        {
                                                            // return view for XmlTestContext.UserDetails_FK
                                                            return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.UserDetails_FK", @"
    SELECT VALUE -- Constructing UserDetails_FK
        XmlTest.UserDetails_FK(T3.[UserDetails_FK.User], T3.[UserDetails_FK.UserDetails])
    FROM (
        SELECT -- Constructing User
            CreateRef(XmlTestContext.User, row(T2.[UserDetails_FK.User.UserId]),XmlTest.User) AS [UserDetails_FK.User],
            T2.[UserDetails_FK.UserDetails]
        FROM (
            SELECT -- Constructing UserDetails
                CreateRef(XmlTestContext.UserDetails, row(T1.[UserDetails_FK.UserDetails.UserId]),XmlTest.UserDetails) AS [UserDetails_FK.UserDetails],
                T1.[UserDetails_FK.User.UserId]
            FROM (
                SELECT
                    T.UserId AS [UserDetails_FK.User.UserId],
                    T.UserId AS [UserDetails_FK.UserDetails.UserId],
                    True AS _from0
                FROM XmlTestStoreContainer.UserDetails AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                                                        }
                                                        else
                                                        {
                                                            if ((index == 12))
                                                            {
                                                                // return view for XmlTestContext.UserToken_FK
                                                                return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.UserToken_FK", @"
    SELECT VALUE -- Constructing UserToken_FK
        XmlTest.UserToken_FK(T3.[UserToken_FK.User], T3.[UserToken_FK.UserToken])
    FROM (
        SELECT -- Constructing User
            CreateRef(XmlTestContext.User, row(T2.[UserToken_FK.User.UserId]),XmlTest.User) AS [UserToken_FK.User],
            T2.[UserToken_FK.UserToken]
        FROM (
            SELECT -- Constructing UserToken
                CreateRef(XmlTestContext.UserToken, row(T1.[UserToken_FK.UserToken.UserId]),XmlTest.UserToken) AS [UserToken_FK.UserToken],
                T1.[UserToken_FK.User.UserId]
            FROM (
                SELECT
                    T.UserId AS [UserToken_FK.User.UserId],
                    T.UserId AS [UserToken_FK.UserToken.UserId],
                    True AS _from0
                FROM XmlTestStoreContainer.UserToken AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                                                            }
                                                            else
                                                            {
                                                                if ((index == 13))
                                                                {
                                                                    // return view for XmlTestStoreContainer.XmlTable
                                                                    return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.XmlTable", @"
    SELECT VALUE -- Constructing XmlTable
        [XmlTest.Store].XmlTable(T1.XmlTable_key, T1.[XmlTable.test_xml])
    FROM (
        SELECT
            T.[key] AS XmlTable_key,
            T.test_xml AS [XmlTable.test_xml],
            True AS _from0
        FROM XmlTestContext.XmlTable AS T
    ) AS T1");
                                                                }
                                                                else
                                                                {
                                                                    if ((index == 14))
                                                                    {
                                                                        // return view for XmlTestContext.XmlTable
                                                                        return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.XmlTable", @"
    SELECT VALUE -- Constructing XmlTable
        XmlTest.XmlTable(T1.XmlTable_key, T1.[XmlTable.test_xml])
    FROM (
        SELECT
            T.[key] AS XmlTable_key,
            T.test_xml AS [XmlTable.test_xml],
            True AS _from0
        FROM XmlTestStoreContainer.XmlTable AS T
    ) AS T1");
                                                                    }
                                                                    else
                                                                    {
                                                                        if ((index == 15))
                                                                        {
                                                                            // return view for XmlTestStoreContainer.dispViews
                                                                            return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.dispViews", @"
    SELECT VALUE -- Constructing dispViews
        [XmlTest.Store].dispViews(T1.dispViews_ViewName, T1.dispViews_MdsIdPlatformId, T1.dispViews_DisplayName, T1.dispViews_ImageFileName)
    FROM (
        SELECT
            T.ViewName AS dispViews_ViewName,
            T.MdsIdPlatformId AS dispViews_MdsIdPlatformId,
            T.DisplayName AS dispViews_DisplayName,
            T.ImageFileName AS dispViews_ImageFileName,
            True AS _from0
        FROM XmlTestContext.dispViews AS T
    ) AS T1");
                                                                        }
                                                                        else
                                                                        {
                                                                            if ((index == 16))
                                                                            {
                                                                                // return view for XmlTestStoreContainer.dispTargetViews
                                                                                return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestStoreContainer.dispTargetViews", @"
    SELECT VALUE -- Constructing dispTargetViews
        [XmlTest.Store].dispTargetViews(T1.dispTargetViews_ViewName, T1.dispTargetViews_MdsIdPlatformId, T1.dispTargetViews_TargetViewName, T1.dispTargetViews_TargetMdsIdPlatformId)
    FROM (
        SELECT
            Key(T.dispViews).ViewName AS dispTargetViews_ViewName,
            Key(T.dispViews).MdsIdPlatformId AS dispTargetViews_MdsIdPlatformId,
            Key(T.dispViews1).ViewName AS dispTargetViews_TargetViewName,
            Key(T.dispViews1).MdsIdPlatformId AS dispTargetViews_TargetMdsIdPlatformId,
            True AS _from0
        FROM XmlTestContext.dispTargetViews AS T
    ) AS T1");
                                                                            }
                                                                            else
                                                                            {
                                                                                if ((index == 17))
                                                                                {
                                                                                    // return view for XmlTestContext.dispViews
                                                                                    return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.dispViews", @"
    SELECT VALUE -- Constructing dispViews
        XmlTest.dispViews(T1.dispViews_ViewName, T1.dispViews_MdsIdPlatformId, T1.dispViews_DisplayName, T1.dispViews_ImageFileName)
    FROM (
        SELECT
            T.ViewName AS dispViews_ViewName,
            T.MdsIdPlatformId AS dispViews_MdsIdPlatformId,
            T.DisplayName AS dispViews_DisplayName,
            T.ImageFileName AS dispViews_ImageFileName,
            True AS _from0
        FROM XmlTestStoreContainer.dispViews AS T
    ) AS T1");
                                                                                }
                                                                                else
                                                                                {
                                                                                    if ((index == 18))
                                                                                    {
                                                                                        // return view for XmlTestContext.dispTargetViews
                                                                                        return new System.Collections.Generic.KeyValuePair<string, string>("XmlTestContext.dispTargetViews", @"
    SELECT VALUE -- Constructing dispTargetViews
        XmlTest.dispTargetViews(T3.dispTargetViews_dispViews, T3.dispTargetViews_dispViews1)
    FROM (
        SELECT -- Constructing dispViews
            CreateRef(XmlTestContext.dispViews, row(T2.dispTargetViews_dispViews_ViewName, T2.dispTargetViews_dispViews_MdsIdPlatformId),XmlTest.dispViews) AS dispTargetViews_dispViews,
            T2.dispTargetViews_dispViews1
        FROM (
            SELECT -- Constructing dispViews1
                CreateRef(XmlTestContext.dispViews, row(T1.dispTargetViews_dispViews1_ViewName, T1.dispTargetViews_dispViews1_MdsIdPlatformId),XmlTest.dispViews) AS dispTargetViews_dispViews1,
                T1.dispTargetViews_dispViews_ViewName, T1.dispTargetViews_dispViews_MdsIdPlatformId
            FROM (
                SELECT
                    T.ViewName AS dispTargetViews_dispViews_ViewName,
                    T.MdsIdPlatformId AS dispTargetViews_dispViews_MdsIdPlatformId,
                    T.TargetViewName AS dispTargetViews_dispViews1_ViewName,
                    T.TargetMdsIdPlatformId AS dispTargetViews_dispViews1_MdsIdPlatformId,
                    True AS _from0
                FROM XmlTestStoreContainer.dispTargetViews AS T
            ) AS T1
        ) AS T2
    ) AS T3");
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            throw new System.IndexOutOfRangeException();
        }
    }
}
