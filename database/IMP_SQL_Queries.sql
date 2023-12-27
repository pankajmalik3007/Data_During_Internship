select * from sales.staffs; 
--select Top Queries
/*While we are retrieving data from an SQL table, the SQL TOP clause is used to restrict the number of rows returned by a SELECT query in SQL server. In addition, we can also use it with UPDATE and 
DELETE statements to limit (restrict) the resultant records.*/
select Top (10-4+1) * from sales.staffs;

SELECT TOP (8 - 4 + 1) *
FROM (
    SELECT *, ROW_NUMBER() OVER (ORDER BY staff_id) AS RowNum
    FROM sales.staffs
) AS Subquery
WHERE RowNum BETWEEN 4 AND 8;
-- Orderby
 select top 4 * from sales.staffs order by staff_id desc;
--Pattern match
 select top 2 * from sales.staffs where last_name like 'b%';
 --Delete Command With Top clause
 delete top (1) from sales.staffs where last_name like 'b%';

 --The SQL DISTINCT Keyword
-- The SQL DISTINCT keyword is used in conjunction with the SELECT statement to fetch unique records from a table.
 select distinct email from sales.staffs order by email;
 select distinct first_name, email from sales.staffs order by email;

 --Count function with Distinct
 select count(manager_id) as Manager from sales.staffs;
 
 --DISTINCT Keyword with NULL Values
 update sales.staffs set manager_id = 1 where store_id = 1;

/*The SQL ORDER BY Clause
The SQL ORDER BY clause is used to sort the data in either ascending or descending order,
based on one or more columns. This clause can sort data by a single column or by multiple 
columns. Sorting by multiple columns can be helpful when you need to sort data hierarchically,
such as sorting by state, city, and then by the person's name.*/

-- Syntax
/*SELECT column-list
FROM table_name
[ORDER BY column1, column2, .. columnN] [ASC | DESC];*/

select * from sales.staffs order by first_name desc;

--orderby on multiple column
select * from sales.staffs order by first_name desc, last_name asc;

--ORDER BY with WHERE Clause
SELECT * FROM sales.staffs WHERE last_name = 'Boyer' ORDER BY last_name DESC;


--ORDER BY with Limit Clause

SELECT *
FROM sales.staffs
ORDER BY first_name
OFFSET 0 ROWS
FETCH NEXT 4 ROWS ONLY;

/*The SQL GROUP BY Clause
The SQL GROUP BY clause is used in conjunction with the SELECT statement to arrange identical
data into groups. This clause follows the WHERE clause in a SELECT statement and precedes the 
ORDER BY and HAVING clauses (if they exist).

The main purpose of grouping the records of a table based on particular columns is to perform 
calculations on these groups. Therefore, The GROUP BY clause is typically used with aggregate 
functions such as SUM(), COUNT(), AVG(), MAX(), or MIN() etc.

Syntax
Following is the basic syntax of the SQL GROUP BY clause −

SELECT column_name(s)
FROM table_name
GROUP BY column_name(s);*/

--GROUP BY Clause with Aggregate Functions
select store_id, count (first_name) as name from sales.staffs group by store_id;

--GROUP BY Clause on Single Columns
select first_name, avg(store_id) as id from sales.staffs group by first_name;

--GROUP BY Clause with Multiple Columns
SELECT first_name, last_name, SUM(store_id) AS TOTAL_ID FROM sales.staffs GROUP BY first_name, last_name;

--GROUP BY Clause with Order by
select first_name , min(store_id) as id from sales.staffs group by first_name order by first_name desc;

select * from sales.order_items;

--Groupby with Having
select product_id, avg(discount) as discount from sales.order_items group by product_id having product_id >2;

/*SQL - AND and OR Conjunctive Operators
Operators are reserved words primarily used in SQL to perform various operations on data, like addition (+), subtraction (-), or comparison (==).

Conjunctive operators, specifically used in boolean logic, combines two conditions in an SQL 
statement. The most common conjunctive operators are: AND (&&), which returns true if both conditions 
are true, and OR (||), which returns true if at least one condition is true.*/

-- Or Condition
select first_name,last_name from sales.staffs where active >1 or manager_id >=1;

--And Condition
select first_name,last_name from sales.staffs where active >=1 or manager_id >=1;

/*SQL - ANY, ALL Operators
The SQL ANY Operator
The ANY operator is used to verify if any single record of a query satisfies the required condition.
*/
SELECT * FROM sales.order_items 
WHERE discount > ANY (SELECT discount FROM sales.order_items WHERE quantity <= 1);

SELECT DISTINCT list_price FROM sales.order_items 
WHERE discount < ANY (SELECT AVG(discount) FROM sales.order_items);

/*ALL with WHERE Statement
When we use the ALL operator with a WHERE clause, it filters the results of the subquery
based on the specified condition.*/

select distinct list_price from  sales.order_items
where discount <> All (select discount from  sales.order_items where discount >= 100 )


-- exists Command 
select * from sales.order_items where Exists (select store_id from sales.orders
where order_id = item_id);

select * from sales.orders;

-- switch case statements
select  list_price ,
case 
when list_price< 600  then 'low quality'
when list_price>600 and list_price<800 then 'mwdium quality'
else 'high quality'
end as quality 
from sales.order_items

select * from production.stocks

-- switch case with orderby
select * from production.products
order by
(case 
when product_id >321  then product_id
else model_year
end);

select 
case 
    when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end as price_status,
	count(list_price) as total
	from sales.order_items
	group by 
	case 
	when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end;

	select 
case 
    when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end as price_status,
	avg(list_price) as total
	from sales.order_items
	group by 
	case 
	when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end;

	select 
case 
    when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end as price_status,
	sum(list_price) as total
	from sales.order_items
	group by 
	case 
	when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end;

	select 
case 
    when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end as price_status,
	min(list_price) as total
	from sales.order_items
	group by 
	case 
	when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end;

	select 
case 
    when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end as price_status,
	max(list_price) as total
	from sales.order_items
	group by 
	case 
	when list_price <=700 then 'Lowest price'
	when list_price >=701 and list_price<=1000 then 'Average Price'
	else 'highest price'
	end;


	select * from production.products

/*CREATE PROCEDURE SelectAllProducts 
    @product_name NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM production.products 
    WHERE product_name = @product_name;
END;
EXEC SelectAllProducts @product_name = 'Sun Bicycles Cruz 3-2017';
*/


--Joins Concept
--Inner Join
select product_name,list_price from production.products
inner join sales.orders on production.products.product_id = sales.orders.order_id;



select * from sales.order_items