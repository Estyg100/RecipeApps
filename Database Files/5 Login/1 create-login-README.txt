Script to create login and user is excluded from this repo.
Create a file called create-login.sql (this file is ignored by git gitignore in this repo).

Add the follwing scripts to that file:

--IMPORTANT create login in master
use master 
go 
create login [loginname] with apssword = '[password]'

--IMPORTANT switch to HeartyHearthDB
use HeartyHearthDB 
go 
create user [username] from login [loginname]