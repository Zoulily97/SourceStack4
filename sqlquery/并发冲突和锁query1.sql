
update BMoney set banlanc=10
select * from BMoney
--利用图和SQL语句演示
--未提交读（READ UNCOMMITTED）
--提交读（READ COMMITTED）
-- 可重复读（REPEATABLE READ）
--序列化（SERIALIZABLE）
-- 存在的和可避免的问题。参考图：

--未提交读（READ UNCOMMITTED）
  dbcc useroptions
  select @@TRANCOUNT

  --未提交读（READ UNCOMMITTED）
  begin  tran
  update  BMoney set banlanc=1 where ReigisterId=3  --query 1
  rollback 
  select * from BMoney   --query 1   3-10

  ---提交读（READ COMMITTED） --造成了不可重复读
  begin tran 
  select * from BMoney  where ReigisterId=3  --query 1  3-10
  select * from BMoney  where ReigisterId=3  --query 1  3-1
  commit
  ---提交读（READ COMMITTED）
  begin tran   --解决了脏读
  update  BMoney set banlanc=1 where ReigisterId=3  --query 1
  rollback
  select * from BMoney
  ---- 可重复读（REPEATABLE READ）--解决了不可重复读
  dbcc useroptions
  select @@TRANCOUNT
  set transaction isolation level repeatable read 
  begin tran 
  select * from BMoney  where ReigisterId=3  --query 1  3-10
  select * from BMoney  where ReigisterId=3  --query 1  3-10
  commit
  ------ 可重复读（REPEATABLE READ）--幻影读问题
  begin tran
  update BMoney set banlanc=100
  select * from BMoney
  commit
  --序列化（SERIALIZABLE）
  set transaction isolation level serializable 
  begin tran
  update BMoney set banlanc=200
  select * from BMoney
  commit


  --死锁
  begin tran
  update BMoney set banlanc=300 where id=1
  update BMoney set banlanc+=300 where id=3
  --Transaction (Process ID 51) was deadlocked on lock resources with another process 
  --and has been chosen as the deadlock victim. Rerun the transaction.

