create table sales.persons
(
		person_id int
		primary key Identity,
		person_name varchar(max),
		last_name varchar(max)
);	

CREATE TABLE sales.deals
(
    deal_id   INT
    PRIMARY KEY IDENTITY, 
    person_id INT NOT NULL, 
    deal_note NVARCHAR(100), 
    FOREIGN KEY(person_id) REFERENCES sales.persons(
    person_id)
);

insert into sales.persons(person_name,last_name)
values ('Pankaj','Malik'),
		('Mayur','Runwal')

insert into 
    sales.deals( deal_id,person_id, deal_note)
values
    (1,1,'Deal for John Doe');

create proc ErrorHandling
as 
begin
		select 
		 ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_LINE () AS ErrorLine  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_MESSAGE() AS ErrorMessage;  
end

create or alter proc deleteoperation
(
	@user_id varchar(Max) 
)
as 
begin
		begin try
		begin transaction
		delete from sales.persons
		where person_name = @user_id
		commit transaction
		end try

		begin catch
		exec ErrorHandling;
		if(XACT_STATE()) = -1
		begin 
		 PRINT  N'The transaction is in an uncommittable state.' +  
                    'Rolling back transaction.' 

		rollback transaction;
		end
		if(XACT_STATE()) = 1
		begin
		 PRINT  N'The transaction is in an committable state.'  
		 commit transaction
         end
		 end catch
end

exec deleteoperation @user_id = 'Pankaj';

select * from sales.persons

-----SQL Server RAISERROR examples
DECLARE 
    @ErrorMessage  NVARCHAR(4000), 
    @ErrorSeverity INT, 
    @ErrorState    INT;

BEGIN TRY
    RAISERROR('Error occurred in the TRY block.', 17, 1);
END TRY
BEGIN CATCH
    SELECT 
        @ErrorMessage = ERROR_MESSAGE(), 
        @ErrorSeverity = ERROR_SEVERITY(), 
        @ErrorState = ERROR_STATE();

    -- return the error inside the CATCH block
    RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
END CATCH;
