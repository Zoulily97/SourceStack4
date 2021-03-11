declare  @name nvarchar(10)
--set @name=N'邹丽'
print @name   

if(@name is null)
begin --总是加上，可读性更高
   print '@name is null'
   print N'哦豁'
end
else
   print 'name is'+@name

 DECLARE @age INT
 set @age=22
IF @age>18
   PRINT 'Adult'
else IF @age>12 
   PRINT 'Teenager'


 DECLARE @age INT
 set @age=0
while (@age<5)
begin  
   print @age
   set @age+=1
end
--0
--1
--2
--3
--4


print ROUND(9.870, 2) 
print floor(9.87)
print ceiling(9.87)
print rand(32)
print rand(32)
  
declare @int int=0
while(@int<500)
 begin 
 set @int +=1
 print floor(rand()*1000)
 end


 go
 --表值函数
 --单行
CREATE function zlinlinetable(@number int)
 returns table   --结果是一张表
 return select top (@number) * from BMoney
 go
 select * from zlinlinetable(3)  --再一次selct,结果需要进一步运算 

 --多行 
  go
 create function zllinestable(@age int,@name nvarchar(20))
 returns @T table(age int,[name] nvarchar(20))
 as
 begin 
 insert @T values(@age,@name)
 return 
 end
 go
 select * from zllinestable(18,N'邹丽')


--存储过程
go
--create procedure GetExcellentStudents  --创建存储过程
alter procedure GetExcellentStudents --修改存储过程
@score int=80  --输入参数，默认80
--@count int output  -- --输出参数
as 
set nocount on ;--关闭影响行数提示
update Student set score+=5;   --存储过程写操作
select * from Student where score>@score;
--给输出参数赋值
--set @count =(select  count(*) from Student where score>@score);
return (select count(*) from Student where score>@score);
set nocount off;--关闭影响行数提示
go

--调用
declare @count int
execute GetExcellentStudents 90,@count  output
select  @count

--调用有返回值的
declare @count int
execute @count=GetExcellentStudents default
select  @count
--默认输入调用
declare @count int
execute GetExcellentStudents default,@count output

select * from sys.procedures where name='GetExcellentStudents'
drop procedure dbo.GetExcellentStudents

--系统存储过程
execute sp_rename @objname=N'Major' 
,@newname=N'Major1',@objtype=N'object'
--Caution: Changing any part of an object name 
--could break scripts and stored procedures.




execute sp_helptext GetExcellentStudents
execute sp_helptext sp_add_agent_parameter



--触发器

  

select @@version-- 全局变量@@version Microsoft SQL Server 2016 (SP1) (KB3182545) 
insert BMoney (banlanc) values(1000)
select @@IDENTITY
select * from BMoney where id=2002
select @@trancount
