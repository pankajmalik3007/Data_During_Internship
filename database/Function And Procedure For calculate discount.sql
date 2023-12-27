create procedure myProcedure
as
begin
select * from sales.order_items;
end;
exec myProcedure



-- Using Function Apply Discount on All Products
Alter FUNCTION dbo.CalculateDiscount
    (@price DECIMAL, @discountPercentage DECIMAL)
RETURNS DECIMAL
AS
BEGIN
    DECLARE @discountedPrice DECIMAL;
	
    SET @discountedPrice = @price - (@price * @discountPercentage / 100);
    RETURN @discountedPrice;
END;
SELECT order_id, list_price, dbo.CalculateDiscount(list_price, 10) AS DiscountedPrice
FROM sales.order_items;




-- apply function for set new colun discount percentage in that table
CREATE FUNCTION dbo.CalculateDiscount1
    (@price DECIMAL, @discountPercentage DECIMAL)
RETURNS TABLE
AS
RETURN
(
		SELECT 
        @price AS original_price, 
        @discountPercentage AS discount_percentage,
        @price - (@price * @discountPercentage / 100) AS discounted_price
);
SELECT order_id, 
       list_price,
       c.original_price,
       c.discount_percentage,
       c.discounted_price
FROM sales.order_items
CROSS APPLY dbo.CalculateDiscount1(list_price, 10) AS c;




--Using Function Apply Discount on Single Product
-- Create the CalculateDiscount2 function
CREATE FUNCTION dbo.CalculateDiscount2
    (@price DECIMAL, @discountPercentage DECIMAL)
RETURNS DECIMAL
AS
BEGIN
    DECLARE @discountedPrice DECIMAL;
    SET @discountedPrice = @price - (@price * @discountPercentage / 100);
    RETURN @discountedPrice;
END;
DECLARE @list_price DECIMAL = 599.99; 
DECLARE @discountPercentage DECIMAL = 10;
SELECT @list_price AS original_price, 
       @discountPercentage AS discount_percentage,
       dbo.CalculateDiscount2(@list_price, @discountPercentage) AS DiscountedPrice;





--Using Procedure Apply Discount On Single Product
create PROCEDURE ApplyDiscountToProducts
    @DiscountPercentage DECIMAL,
	@list_price DECIMAL,
	@DiscountedPrice decimal output

AS
BEGIN
   
    SET @DiscountedPrice = @list_price - (@list_price  * @DiscountPercentage / 100);
END;

DECLARE @DiscountPercentage DECIMAL = 10; 
DECLARE @ListPrice DECIMAL = 2999.99;
DECLARE @DiscountedPrice DECIMAL; 

EXEC ApplyDiscountToProducts @DiscountPercentage, @ListPrice, @DiscountedPrice OUTPUT;

PRINT 'Discounted Price: ' + CAST(@DiscountedPrice AS NVARCHAR);

--Using Procedure Apply Discount On All Product
create PROCEDURE CalculateDiscountedPrices
    @DiscountPercentage DECIMAL
AS
BEGIN
    SELECT order_id, 
           list_price AS original_price, 
		    @DiscountPercentage AS discount_percentage,
           ROUND(list_price - (list_price * @DiscountPercentage / 100), 2) AS discounted_price
    FROM sales.order_items;
END;
DECLARE @DiscountPercentage DECIMAL = 10; 

EXEC CalculateDiscountedPrices @DiscountPercentage;




--Using Procedure Apply Discount On All Product also using output Parameter
CREATE PROCEDURE CalculateDiscountedPrices1
    @DiscountPercentage DECIMAL,
    @AppliedDiscountPercentage DECIMAL OUTPUT
AS
BEGIN
    SELECT order_id, 
           list_price AS original_price, 
           @DiscountPercentage AS discount_percentage,
           ROUND(list_price - (list_price * @DiscountPercentage / 100), 2) AS discounted_price
    FROM sales.order_items;

    SET @AppliedDiscountPercentage = @DiscountPercentage;
END;
DECLARE @DiscountPercentage DECIMAL = 10; -- Specify your discount percentage here
DECLARE @AppliedDiscountPercentage DECIMAL;

EXEC CalculateDiscountedPrices1 @DiscountPercentage, @AppliedDiscountPercentage OUTPUT;

PRINT 'Discount Percentage Applied: ' + CAST(@AppliedDiscountPercentage AS NVARCHAR);

execute myProcedure

select * from sales.customers

Create procedure  GetCustomerInfo
(@Customername varchar(100),
@phone varchar(200))
As
   BEGIN
      SELECT * FROM sales.customers WHERE last_name = @Customername;
	  SELECT * FROM sales.customers WHERE phone = @phone;

	  END 
Exec GetCustomerInfo  @Customername = 'Burks', @phone = '(916) 381-6003';


CREATE OR ALTER PROCEDURE insertvalue
(
    @phoneno VARCHAR(100)
)
AS
BEGIN
    UPDATE sales.customers
    SET phone = @phoneno
    WHERE last_name = 'Todd';
END
EXEC insertvalue @phoneno = '(916) 381-6003';