-- [ Schemas ] -------------------------------------------------
-- [ Schemas ] -------------------------------------------------
CREATE SCHEMA Pizza;
GO

CREATE SCHEMA Store;
GO

CREATE SCHEMA Information;
GO

CREATE SCHEMA People;
GO

-- [ Tables ] --------------------------------------------------
-- [ Tables ] --------------------------------------------------
CREATE TABLE Pizza.Ingredient (
    IngredientId INT NOT NULL IDENTITY PRIMARY KEY,
    Name NVARCHAR(64) NOT NULL,
    Price MONEY NOT NULL,
    [Type] NVARCHAR(32) NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Pizza.PizzaIngredient (
    PizzaId INT NOT NULL,
    IngredientId INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Pizza.SpecialtyPizzaIngredient (
    SpecialtyPizzaId INT NOT NULL,
    IngredientId INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Pizza.Pizza (
    PizzaId INT NOT NULL IDENTITY PRIMARY KEY,
    OrderId INT NULL,
    SizeId INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Pizza.Size (
    SizeId INT NOT NULL IDENTITY PRIMARY KEY,
    Dimension INT NOT NULL,
    Price MONEY NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Pizza.SpecialtyPizza (
    SpecialtyPizzaId INT NOT NULL IDENTITY PRIMARY KEY,
    Name NVARCHAR(64) NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Store.[Order] (
    OrderId INT NOT NULL PRIMARY KEY,
    SubTotal MONEY NOT NULL,
    Tax MONEY NOT NULL,
    Total MONEY NOT NULL,
    StoreId INT NOT NULL,
    CustomerId INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

--CREATE TABLE Store.PizzaOrder (
--    PizzaId INT NOT NULL,
--    OrderId INT NOT NULL,
--    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
--    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
--    Active BIT NOT NULL DEFAULT 1
--);
--GO

CREATE TABLE Store.Store (
    StoreId INT NOT NULL IDENTITY PRIMARY KEY,
    OwnerId INT NOT NULL,
    PhoneId INT NOT NULL,
    AddressId INT NOT NULL,
    SalesTax DECIMAL NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Store.StoreIngredient (
    StoreId INT NOT NULL,
    IngredientId INT NOT NULL,
    Quantity INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Information.[Address] (
    AddressId INT NOT NULL IDENTITY PRIMARY KEY,
    Street NVARCHAR(256) NOT NULL,
    City NVARCHAR(64) NOT NULL,
    [State] CHAR(2) NOT NULL,
    Zip CHAR(5) NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Information.Phone (
    PhoneId INT NOT NULL IDENTITY PRIMARY KEY,
    Number CHAR(10) NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE People.Person (
    PersonId INT NOT NULL IDENTITY PRIMARY KEY,
    FirstName NVARCHAR(64) NOT NULL,
    LastName NVARCHAR(64) NOT NULL,
    PhoneId INT NULL,
    AddressId INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    UpdatedDate DATETIME NOT NULL DEFAULT GETUTCDATE(),
    Active BIT NOT NULL DEFAULT 1
);
GO

ALTER TABLE Pizza.Ingredient
    ADD CONSTRAINT ch_Type CHECK ([Type] IN ('Crust', 'Sauce', 'Cheese', 'Topping'));
GO

ALTER TABLE Pizza.PizzaIngredient
    ADD CONSTRAINT pk_PizzaIngredientId PRIMARY KEY (PizzaId, IngredientId);
GO

ALTER TABLE Pizza.PizzaIngredient
    ADD CONSTRAINT fk_PizzaIngredient_PizzaId FOREIGN KEY (PizzaId) REFERENCES Pizza.Pizza(PizzaId);
GO

ALTER TABLE Pizza.PizzaIngredient
    ADD CONSTRAINT fk_PizzaIngredient_IngredientId FOREIGN KEY (IngredientId) REFERENCES Pizza.Ingredient(IngredientId);
GO

ALTER TABLE Pizza.SpecialtyPizzaIngredient
    ADD CONSTRAINT fk_SpecialtyPizzaIngredient_SpecialtyPizzaId FOREIGN KEY (SpecialtyPizzaId) REFERENCES Pizza.SpecialtyPizza(SpecialtyPizzaId);
GO

ALTER TABLE Pizza.SpecialtyPizzaIngredient
    ADD CONSTRAINT fk_SpecialtyPizzaIngredient_IngredientId FOREIGN KEY (IngredientId) REFERENCES Pizza.Ingredient(IngredientId);
GO

ALTER TABLE Pizza.Pizza
    ADD CONSTRAINT fk_Pizza_OrderId FOREIGN KEY (OrderId) REFERENCES Store.[Order](OrderId);
GO

ALTER TABLE Pizza.Pizza
    ADD CONSTRAINT fk_Pizza_SizeId FOREIGN KEY (SizeId) REFERENCES Pizza.Size(SizeId);
GO

ALTER TABLE Store.[Order]
    ADD CONSTRAINT fk_Order_StoreId FOREIGN KEY (StoreId) REFERENCES Store.Store(StoreId);
GO

ALTER TABLE Store.[Order]
    ADD CONSTRAINT fk_Order_CustomerId FOREIGN KEY (CustomerId) REFERENCES People.Person(PersonId);
GO

--ALTER TABLE Store.PizzaOrder
--    ADD CONSTRAINT pk_PizzaOrderId PRIMARY KEY (PizzaId, OrderId);
--GO

--ALTER TABLE Store.PizzaOrder
--    ADD CONSTRAINT fk_PizzaOrder_PizzaId FOREIGN KEY (PizzaId) REFERENCES Pizza.Pizza(PizzaId);
--GO

--ALTER TABLE Store.PizzaOrder
--    ADD CONSTRAINT fk_PizzaOrder_OrderId FOREIGN KEY (OrderId) REFERENCES Store.[Order](OrderId);
--GO

ALTER TABLE Store.Store
    ADD CONSTRAINT fk_Store_OwnerId FOREIGN KEY (OwnerId) REFERENCES People.Person(PersonId);
GO

ALTER TABLE Store.Store
    ADD CONSTRAINT fk_Store_PhoneId FOREIGN KEY (PhoneId) REFERENCES Information.Phone(PhoneId);
GO

ALTER TABLE Store.Store
    ADD CONSTRAINT fk_Store_AddressId FOREIGN KEY (AddressId) REFERENCES Information.[Address](AddressId);
GO

ALTER TABLE Store.StoreIngredient
    ADD CONSTRAINT pk_StoreIngredientId PRIMARY KEY (StoreId, IngredientId);
GO

ALTER TABLE Store.StoreIngredient
    ADD CONSTRAINT fk_StoreIngredient_StoreId FOREIGN KEY (StoreId) REFERENCES Store.Store(StoreId);
GO

ALTER TABLE Store.StoreIngredient
    ADD CONSTRAINT fk_StoreIngredient_IngredientId FOREIGN KEY (IngredientId) REFERENCES Pizza.Ingredient(IngredientId);
GO

ALTER TABLE People.Person
    ADD CONSTRAINT fk_Person_PhoneId FOREIGN KEY (PhoneId) REFERENCES Information.Phone(PhoneId);
GO

ALTER TABLE People.Person
    ADD CONSTRAINT fk_Person_AddressId FOREIGN KEY (AddressId) REFERENCES Information.[Address](AddressId);
GO
CREATE PROCEDURE sp_CreateDeleteTrigger(@triggerName NVARCHAR(64), @idName NVARCHAR(64), @tableName NVARCHAR(64))
AS BEGIN
    SET NOCOUNT ON;
    DECLARE @query NVARCHAR(MAX)

    SET @query = 'CREATE TRIGGER tr_' + @triggerName + ' ON ' + @tableName + '
        INSTEAD OF DELETE
        AS BEGIN
            DECLARE @active BIT;
            SELECT @active = Active FROM deleted;
            IF @active = 1
                UPDATE ' + @tableName + ' SET
                    Active = 0,
                    UpdatedDate = GETUTCDATE()
                FROM ' + @tableName + ' AS t
                    INNER JOIN deleted ON t.' + @idName + ' = deleted.' + @idName + ';
            ELSE
                DELETE ' + @tableName + '
                FROM ' + @tableName + ' AS t
                    INNER JOIN deleted ON t.' + @idName + ' = deleted.' + @idName + ';
        END;'

    EXEC sp_executesql @query
END;
GO
CREATE PROCEDURE sp_CreateJunctionDeleteTrigger(@triggerName NVARCHAR(64), @id1Name NVARCHAR(64), @id2Name NVARCHAR(64), @tableName NVARCHAR(64))
AS BEGIN
    SET NOCOUNT ON;
    DECLARE @query NVARCHAR(MAX)

    SET @query = 'CREATE TRIGGER tr_' + @triggerName + ' ON ' + @tableName + '
        INSTEAD OF DELETE
        AS BEGIN
            DECLARE @active BIT;
            SELECT @active = Active FROM deleted;
            IF @active = 1
                UPDATE ' + @tableName + ' SET
                    Active = 0,
                    UpdatedDate = GETUTCDATE()
                FROM ' + @tableName + ' AS t
                    INNER JOIN deleted ON t.' + @id1Name + ' = deleted.' + @id1Name + '
                        AND t.' + @id2Name + ' = deleted.' + @id2Name + ';
            ELSE
                DELETE ' + @tableName + '
                FROM ' + @tableName + ' AS t
                    INNER JOIN deleted ON t.' + @id1Name + ' = deleted.' + @id1Name + '
                        AND t.' + @id2Name + ' = deleted.' + @id2Name + ';
        END;'

    EXEC sp_executesql @query
END;
GO
CREATE PROCEDURE sp_CreateUpdateTrigger(@triggerName NVARCHAR(64), @idName NVARCHAR(64), @tableName NVARCHAR(64))
AS BEGIN
    SET NOCOUNT ON;
    DECLARE @query NVARCHAR(MAX)

    SET @query = 'CREATE TRIGGER tr_' + @triggerName + ' ON ' + @tableName + '
        AFTER UPDATE
        AS BEGIN
            UPDATE ' + @tableName + ' SET
                UpdatedDate = GETUTCDATE()
            FROM ' + @tableName + ' AS t
                INNER JOIN inserted ON t.' + @idName + ' = inserted.' + @idName + '
        END;'

    EXEC sp_executesql @query
END;
GO
CREATE PROCEDURE sp_CreateJunctionUpdateTrigger(@triggerName NVARCHAR(64), @id1Name NVARCHAR(64), @id2Name NVARCHAR(64), @tableName NVARCHAR(64))
AS BEGIN
    SET NOCOUNT ON;
    DECLARE @query NVARCHAR(MAX)

    SET @query = 'CREATE TRIGGER tr_' + @triggerName + ' ON ' + @tableName + '
        AFTER UPDATE
        AS BEGIN
            UPDATE ' + @tableName + ' SET
                UpdatedDate = GETUTCDATE()
            FROM ' + @tableName + ' AS t
                INNER JOIN inserted ON t.' + @id1Name + ' = inserted.' + @id1Name + '
                    AND t.' + @id2Name + ' = inserted.' + @id2Name + ';
        END;'

    EXEC sp_executesql @query
END;
GO

--CREATE TRIGGER tr_Trigger ON Pizza.PizzaIngredient
--INSTEAD OF DELETE
--AS BEGIN
--    DECLARE @active BIT;
--    IF deleted.Active = 1
--        UPDATE Pizza.PizzaIngredient SET
--            Active = 0,
--            UpdatedDate = GETUTCDATE()
--        FROM Pizza.PizzaIngredient AS p
--            INNER JOIN deleted ON p.PizzaId = deleted.PizzaId
--                AND p.IngredientId = deleted.IngredientId;
--    ELSE
--        DELETE People.Person
--        FROM deleted
--        WHERE PersonId = deleted.PersonId;
--END;
--GO

--CREATE TRIGGER tr_Trigger ON People.Person
--AFTER UPDATE
--AS BEGIN
--    UPDATE People.Person SET
--        UpdatedDate = GETUTCDATE()
--    WHERE PersonId = inserted.PersonId
--END;
--GO