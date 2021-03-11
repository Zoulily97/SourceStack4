
declare @i int=1,@j nvarchar(10)='',@k int,@e int,@s nvarchar(10)
--print 
--set @number=4
while (@i<=5)
begin 
   set @s='' 
   set @k=1
  while (@k<=5-@i)
  begin
  print @j
  set @k+=1
  end
  set @e=1
  while(@e<=2*@i-1)
  begin
  print @i*2-1
  set @e+=1
  end   
   set  @i+=1
end
go

--TProblem中：
--找出所有周末发布的求助（添加CreateTime列，如果还没有的话）
--找出每个作者所有求助悬赏的平均值，精确到小数点后两位
--有一些标题以test、[test]后者Test-开头的求助，找打他们并把这些前缀都换成大写
--定义一个函数RANDINT(INT max)，可以取0-max之间的最大值
select * from [Problem]
