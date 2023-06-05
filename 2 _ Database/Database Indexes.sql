-- primary key (PK) => logical concept
    --unique 
    --not null
-- Clustered Index => physical concept
    --Index that affects the order in which data is stored in disk
	
-- Non Clustered Index
	--Index where the order does not match the physical order of the actual data
	
	
-- clear cache => 
-- Remove all elements from the plan cache for the entire instance
--  DBCC FREEPROCCACHE;
   
-- clear cache => 
-- Flush the plan cache for the entire instance
--   DBCC FREEPROCCACHE
     
-- Get execution time down to milliseconds
--  set statistics time, IO on
--  set statistics time, IO off
   
-- SELECT COUNT(*) FROM Accounts;

-- First Name Index
-- CREATE INDEX ACCOUNTS FIRSTNAME_IX
-- ON Accounts( FirstName) ;
-- After Index
-- SELECT COUNT(*) FROM Accounts WHERE FirstName = ‘Marcos’;

-- Multi Column Index
-- CREATE INDEX ACCOUNTS_EMAIL_ACCOUNTTYPE_IX
-- ON Accounts(Email, AccountType);