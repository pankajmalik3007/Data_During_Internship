select * from BUYERS_VIEW;

SELECT order_id, order_date FROM sales.orders WHERE store_id = 1;

update sales.orders 
SET order_status = 5 where order_id = 1;

select * from sales.orders where customer_id between 4 and 10
SELECT * FROM sales.orders
WHERE shipped_date IS NULL;

CREATE VIEW BUYERS_VIEW  as select * from sales.orders where customer_id > 100;