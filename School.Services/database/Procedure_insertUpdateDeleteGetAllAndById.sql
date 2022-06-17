---  insert And update procedure ------

Create Procedure InsertUpdate(
@Name varchar(50),
@RollNo int,
@Address varchar(50),
@Id int=0)
as 
begin
if(@Id=0)
begin
INSERT INTO Students
           (Name
           ,RollNo
           ,Address)
     VALUES
           (@Name,
           @RollNo,
           @Address)
end
else
	  begin
		UPDATE Students
		   SET Name = @Name,
			  RollNo = @RollNo,
			  Address = @Address
		 WHERE Id=@Id

	  end
end

-----------------------------------

-- getby id and getall procedure --

create procedure GetAllAndId(
@id int=0
)
as
begin 

select * from Students where @id=0 or @id=Id
end

-----------------------------------

------   Delete procedure   -------

create procedure DeleteId(
@Id int)
as
begin
delete from Students where Id=@Id
end

-----------------------------------