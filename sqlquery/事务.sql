create table BMoney(
id int primary key identity(1,1),
 ReigisterId int,
 banlanc int)
 alter table bmoney
 add constraint ck_balance check (banlanc >0)


 begin try
begin tran
--insert problem values(23,'111','111',null,20,'2020/1/1',3)
update BMoney set banlanc -=20 
commit
end try
begin catch 
rollback;
throw
end catch

insert BMoney values(3,5)
select * from BMoney

begin tran
 begin try
--insert problem values(23,'111','111',null,20,'2020/1/1',3)
update BMoney set banlanc -=20  where ReigisterId=3
commit
end try
begin catch 
rollback;
throw
end catch



   begin tran
   begin try
--insert problem values(23,'111','111',null,20,'2020/1/1',3)
     update BMoney set banlanc -=20  where ReigisterId=3
   commit
   end try
   begin catch 
      rollback;
      throw
   end catch


--事务嵌套 
begin tran
   update BMoney set banlanc =20  where ReigisterId=3
   begin tran
   begin try
      update BMoney set banlanc -=70  where ReigisterId=3
   commit
   end try
   begin catch 
      rollback;
      throw
   end catch
commit

select * from BMoney

select @@TRANCOUNT

--save point
begin tran 
  update BMoney set banlanc =60  where ReigisterId=3
     begin tran
     save tran inner_tran    ---save point
     begin try
        update BMoney set banlanc -=60  where ReigisterId=3
     commit 
     end try
     begin catch 
       rollback  tran  inner_tran  ;--回滚到事务点
       commit tran ;---跟随事务点
       -- throw
     end catch
 commit  --真正事务提交



 --隐式事务
 set implicit_transactions  on
 --select * from BMoney
 update BMoney set banlanc=30
 commit
 set implicit_transactions off--习惯性的写上

 rollback
 set implicit_transactions off
 select @@TRANCOUNT


 --事务隔离级别
 dbcc useroptions
 begin tran 
 update BMoney set banlanc=30
 rollback
 
 commit


 
select @@TRANCOUNT
 begin　tran 
 select *  from BMoney

 select * from BMoney

 
 