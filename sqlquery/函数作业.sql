
--TProblem中：
--找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写
--定义一个函数RANDINT(INT max)，可以取0-max之间的最大值


---找出所有周末发布的求助（添加CreateTime列，如果还没有的话
select *,datename(weekday,TPublishTime ) 周几
from problem    where datename(weekday,TPublishTime )='星期六'
or datename(weekday,TPublishTime )='星期日' 
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位
select avg(round(Reward,2)),author from 
Problem group by author
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写
update problem set Title= replace(
title,
substring(title,1,4),
upper(substring(title,1,4)) ) where 
Title like 'test%' or  
Title like 'Test-%'
update problem set Title= replace(
title,
substring(title,1,5),
upper(substring(title,1,5)) ) where Title like '[[]test]%'
select * from problem where 
Title like 'test%' or  
Title like 'Test-%' or
Title like '[[]test]%'
select @@TRANCOUNT
--定义一个函数RANDINT(INT max)，可以取0-max之间的最大值
go
create function RANDINT(@max int)  
returnS @T TABLE(NUMBER INT)
AS
BEGIN
declare @num int
set @num=0
while(@num<=@max)
begin
INSERT @T values (@num)
set @num+=1
end
return
END
go
select * from RANDINT(10)
go
drop function dbo.RANDINT;


alter table [problem]
alter column  reward float not null
--datename(weekday,@datetime)
--select * from Problem where 
--SQL取出 所有周六 周日的日期
create table SatSun(
[id] int identity(1,1),
[date] datetime,
[weekday] char(6))
go
declare @datetime datetime,@weekday char(6)
set @datetime='2007-1-1'
while @datetime<='2007-12-31'
begin
select @weekday=datename(weekday,@datetime)
if @weekday= '星期六' insert SatSun([date],[weekday]) values(@datetime,@weekday)
if @weekday='星期日' insert SatSun([date],[weekday]) values(@datetime,'星期天')
select @datetime=dateadd(day,1,@datetime)
end
go
select * from SatSun
