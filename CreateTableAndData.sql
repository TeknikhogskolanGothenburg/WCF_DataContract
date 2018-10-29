Create Table tblEmployee
(
  Id int,
  Name nvarchar(50),
  Gender nvarchar(50),
  DateOfBirth datetime
)

Insert into tblEmployee values (1, 'Mark', 'Male', '10/10/1980')
Insert into tblEmployee values (2, 'Mary', 'Female', '11/10/1981')
Insert into tblEmployee values (3, 'Tom', 'Male', '12/10/1982')

Create procedure spGetEmployee
@Id int
as
Begin
  Select Id, Name, Gender, DateOfBirth
  from tblEmployee
  where Id = @Id
End


Create procedure spSaveEmployee
@Id int,
@Name nvarchar(50),
@Gender nvarchar(50),
@DateOfBirth DateTime
as
Begin
  Insert into tblEmployee
  values (@Id, @Name, @Gender, @DateOfBirth)
End



