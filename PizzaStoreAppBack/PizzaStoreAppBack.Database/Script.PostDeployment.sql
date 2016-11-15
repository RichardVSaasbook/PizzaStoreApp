/*
Post-Deployment Script Template                            
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.        
 Use SQLCMD syntax to include a file in the post-deployment script.            
 Example:      :r .\myfile.sql                                
 Use SQLCMD syntax to reference a variable in the post-deployment script.        
 Example:      :setvar TableName MyTable                            
               SELECT * FROM [$(TableName)]                    
--------------------------------------------------------------------------------------
*/

EXEC dbo.sp_CreateDeleteTrigger N'DeleteIngredient', N'IngredientId', N'Pizza.Ingredient';
GO

EXEC dbo.sp_CreateJunctionDeleteTrigger N'DeletePizzaIngredient', N'PizzaId', N'IngredientId', N'Pizza.PizzaIngredient';
GO

EXEC dbo.sp_CreateJunctionDeleteTrigger N'DeleteSpecialtyPizzaIngredient', N'SpecialtyPizzaId', N'IngredientId', N'Pizza.SpecialtyPizzaIngredient';
GO

EXEC dbo.sp_CreateDeleteTrigger N'DeletePizza', N'PizzaId', N'Pizza.Pizza';
GO

EXEC dbo.sp_CreateDeleteTrigger N'DeleteSize', N'SizeId', N'Pizza.Size';
GO

EXEC dbo.sp_CreateDeleteTrigger N'DeleteSpecialtyPizza', N'SpecialtyPizzaId', N'Pizza.SpecialtyPizza';
GO

EXEC dbo.sp_CreateDeleteTrigger N'DeleteOrder', N'OrderId', N'Store.[Order]';
GO

--EXEC dbo.sp_CreateJunctionDeleteTrigger N'DeletePizzaOrder', N'PizzaId', N'OrderId', N'Store.PizzaOrder';
--GO

EXEC dbo.sp_CreateDeleteTrigger N'DeleteStore', N'StoreId', N'Store.Store';
GO

EXEC dbo.sp_CreateJunctionDeleteTrigger N'DeleteStoreIngredient', N'StoreId', N'IngredientId', N'Store.StoreIngredient';
GO

EXEC dbo.sp_CreateDeleteTrigger N'DeleteAddress', N'AddressId', N'Information.Address';
GO

EXEC dbo.sp_CreateUpdateTrigger N'DeletePhone', N'PhoneId', N'Information.Phone';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdateIngredient', N'IngredientId', N'Pizza.Ingredient';
GO

EXEC dbo.sp_CreateJunctionUpdateTrigger N'UpdatePizzaIngredient', N'PizzaId', N'IngredientId', N'Pizza.PizzaIngredient';
GO

EXEC dbo.sp_CreateJunctionUpdateTrigger N'UpdateSpecialtyPizzaIngredient', N'SpecialtyPizzaId', N'IngredientId', N'Pizza.SpecialtyPizzaIngredient';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdatePizza', N'PizzaId', N'Pizza.Pizza';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdateSize', N'SizeId', N'Pizza.Size';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdateSpecialtyPizza', N'SpecialtyPizzaId', N'Pizza.SpecialtyPizza';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdateOrder', N'OrderId', N'Store.[Order]';
GO

--EXEC dbo.sp_CreateJunctionUpdateTrigger N'UpdatePizzaOrder', N'PizzaId', N'OrderId', N'Store.PizzaOrder';
--GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdateStore', N'StoreId', N'Store.Store';
GO

EXEC dbo.sp_CreateJunctionUpdateTrigger N'UpdateStoreIngredient', N'StoreId', N'IngredientId', N'Store.StoreIngredient';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdateAddress', N'AddressId', N'Information.Address';
GO

EXEC dbo.sp_CreateUpdateTrigger N'UpdatePhone', N'PhoneId', N'Information.Phone';
GO

INSERT INTO Pizza.Ingredient (Name, Price, [Type]) VALUES
    (N'Thin', 1.99, N'Crust'),
    (N'Thick', 2.99, N'Crust'),
    (N'Deep Dish', 3.49, N'Crust'),
    (N'Cheese Stuffed', 3.49, N'Crust'),
    (N'Bacon Stuffed', 4.99, N'Crust'),
    (N'Pretzel Cheese Stuffed', 3.99, N'Crust'),
    (N'Garlic', 2.49, N'Crust'),
    (N'Tomato', 0.74, N'Sauce'),
    (N'Pesto', 0.99, N'Sauce'),
    (N'Barbeque', 0.99, N'Sauce'),
    (N'Salsa', 1.24, N'Sauce'),
    (N'Ranch', 0.99, N'Sauce'),
    (N'Romesco', 1.24, N'Sauce'),
    (N'Mozzarella', 0.99, N'Cheese'),
    (N'Chedder', 0.99, N'Cheese'),
    (N'American', 0.49, N'Cheese'),
    (N'Pepperoni', 0.29, N'Topping'),
    (N'Sausage', 0.39, N'Topping'),
    (N'Bacon', 1.49, N'Topping'),
    (N'Jalapeños', 0.49, N'Topping'),
    (N'Ham', 0.39, N'Topping'),
    (N'Garlic', 0.29, N'Topping'),
    (N'Basil', 0.39, N'Topping'),
    (N'Spinach', 0.39, N'Topping'),
    (N'Onions', 0.39, N'Topping'),
    (N'Mushrooms', 0.49, N'Topping'),
    (N'Pineapple', 0.39, N'Topping'),
    (N'Bell Peppers', 0.49, N'Topping'),
    (N'Olives', 0.39, N'Topping');
GO

INSERT INTO Pizza.Size (Dimension, Price) VALUES
    (6, 6.99),
    (12, 11.99),
    (18, 14.99);
GO

INSERT INTO Pizza.SpecialtyPizza (Name) VALUES
    (N'Pepperoni'),
    (N'Cheese'),
    (N'Meat Lovers'),
    (N'Hawaiian'),
    (N'Supreme');
GO

INSERT INTO Pizza.SpecialtyPizzaIngredient (SpecialtyPizzaId, IngredientId) VALUES
    (1, 2),
    (1, 8),
    (1, 14),
    (1, 17),
    (2, 2),
    (2, 8),
    (2, 14),
    (3, 2),
    (3, 8),
    (3, 14),
    (3, 17),
    (3, 18),
    (3, 19),
    (3, 21),
    (4, 2),
    (4, 8),
    (4, 14),
    (4, 21),
    (4, 27),
    (5, 2),
    (5, 8),
    (5, 14),
    (5, 17),
    (5, 18),
    (5, 26),
    (5, 28),
    (5, 29);
GO

INSERT INTO Information.[Address] (Street, City, [State], Zip) VALUES
    (N'2071 W Millbrook Rd', N'Raleigh', 'NC', '27612'),
    (N'11642 Plaza America Dr', N'Reston', 'VA', '20190'),
    (N'10123 Louetta Rd', N'Houston', 'TX', '77070'),
    (N'4280 E Indian School Rd', N'Phoenix', 'AZ', '85018'),
    (N'8985 Venice Blvd', N'Los Angeles', 'CA', '90034');
GO

INSERT INTO Information.Phone (Number) VALUES
    ('9199873668'),
    ('7036743599'),
    ('2818265001'),
    ('6023148379'),
    ('4243459282');
GO

INSERT INTO People.Person (FirstName, LastName, PhoneId, AddressId) VALUES
    (N'Alisa', N'Reinford', 1, 1),
    (N'Rean', N'Schwarzer', 2, 2),
    (N'Emma', N'Millstein', 3, 3),
    (N'Laura', N'Arseid', 4, 4),
    (N'Elliot', N'Craig', 5, 5);
GO

INSERT INTO Store.Store (OwnerId, PhoneId, AddressId, SalesTax) VALUES
    (1, 1, 1, 0.085),
    (2, 2, 2, 0.053),
    (3, 3, 3, 0.0625),
    (4, 4, 4, 0.056),
    (5, 5, 5, 0.075);
GO

INSERT INTO Store.StoreIngredient (StoreId, IngredientId, Quantity) VALUES
    (1, 1, 99),
    (1, 2, 99),
    (1, 3, 99),
    (1, 4, 99),
    (1, 5, 99),
    (1, 6, 99),
    (1, 7, 99),
    (1, 8, 99),
    (1, 9, 99),
    (1, 10, 99),
    (1, 11, 99),
    (1, 12, 99),
    (1, 13, 99),
    (1, 14, 99),
    (1, 15, 99),
    (1, 16, 99),
    (1, 17, 99),
    (1, 18, 99),
    (1, 19, 99),
    (1, 20, 99),
    (1, 21, 99),
    (1, 22, 99),
    (1, 23, 99),
    (1, 24, 99),
    (1, 25, 99),
    (1, 26, 99),
    (1, 27, 99),
    (1, 28, 99),
    (1, 29, 99),
    (2, 1, 99),
    (2, 2, 99),
    (2, 3, 99),
    (2, 4, 99),
    (2, 5, 99),
    (2, 6, 99),
    (2, 7, 99),
    (2, 8, 99),
    (2, 9, 99),
    (2, 10, 99),
    (2, 11, 99),
    (2, 12, 99),
    (2, 13, 99),
    (2, 14, 99),
    (2, 15, 99),
    (2, 16, 99),
    (2, 17, 99),
    (2, 18, 99),
    (2, 19, 99),
    (2, 20, 99),
    (2, 21, 99),
    (2, 22, 99),
    (2, 23, 99),
    (2, 24, 99),
    (2, 25, 99),
    (2, 26, 99),
    (2, 27, 99),
    (2, 28, 99),
    (2, 29, 99),
    (3, 1, 99),
    (3, 2, 99),
    (3, 3, 99),
    (3, 4, 99),
    (3, 5, 99),
    (3, 6, 99),
    (3, 7, 99),
    (3, 8, 99),
    (3, 9, 99),
    (3, 10, 99),
    (3, 11, 99),
    (3, 12, 99),
    (3, 13, 99),
    (3, 14, 99),
    (3, 15, 99),
    (3, 16, 99),
    (3, 17, 99),
    (3, 18, 99),
    (3, 19, 99),
    (3, 20, 99),
    (3, 21, 99),
    (3, 22, 99),
    (3, 23, 99),
    (3, 24, 99),
    (3, 25, 99),
    (3, 26, 99),
    (3, 27, 99),
    (3, 28, 99),
    (3, 29, 99),
    (4, 1, 99),
    (4, 2, 99),
    (4, 3, 99),
    (4, 4, 99),
    (4, 5, 99),
    (4, 6, 99),
    (4, 7, 99),
    (4, 8, 99),
    (4, 9, 99),
    (4, 10, 99),
    (4, 11, 99),
    (4, 12, 99),
    (4, 13, 99),
    (4, 14, 99),
    (4, 15, 99),
    (4, 16, 99),
    (4, 17, 99),
    (4, 18, 99),
    (4, 19, 99),
    (4, 20, 99),
    (4, 21, 99),
    (4, 22, 99),
    (4, 23, 99),
    (4, 24, 99),
    (4, 25, 99),
    (4, 26, 99),
    (4, 27, 99),
    (4, 28, 99),
    (4, 29, 99),
    (5, 1, 99),
    (5, 2, 99),
    (5, 3, 99),
    (5, 4, 99),
    (5, 5, 99),
    (5, 6, 99),
    (5, 7, 99),
    (5, 8, 99),
    (5, 9, 99),
    (5, 10, 99),
    (5, 11, 99),
    (5, 12, 99),
    (5, 13, 99),
    (5, 14, 99),
    (5, 15, 99),
    (5, 16, 99),
    (5, 17, 99),
    (5, 18, 99),
    (5, 19, 99),
    (5, 20, 99),
    (5, 21, 99),
    (5, 22, 99),
    (5, 23, 99),
    (5, 24, 99),
    (5, 25, 99),
    (5, 26, 99),
    (5, 27, 99),
    (5, 28, 99),
    (5, 29, 99);
GO