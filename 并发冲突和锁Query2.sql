  dbcc useroptions
  select @@TRANCOUNT


  --未提交读（READ UNCOMMITTED）  --造成了脏读
  set transaction isolation level read uncommitted
  select * from BMoney   

  --
  ---提交读（READ COMMITTED）--造成了不可重复读
  set transaction isolation level read committed
  update BMoney  set banlanc=1 where ReigisterId=3  ---query2  成功执行

  ---提交读（READ COMMITTED  --解决了脏读
   select * from BMoney  --正在执行,
                         --第一个事务update完成后，才能读
   ---- 可重复读（REPEATABLE READ）---解决了不可重复读
   update BMoney  set banlanc=1 where ReigisterId=3  ---query2   正在执行,
                                                      --第一个事务完成后，才能更新


    ------ 可重复读（REPEATABLE READ）--幻影读问题
    insert BMoney values('99',99)

    ----序列化（SERIALIZABLE）
    insert BMoney values('99',99)

    --死锁
    begin tran
    update BMoney set banlanc=300 where id=3

    update BMoney set banlanc+=300 where id=1
    -- (1 行受影响)
    commit
