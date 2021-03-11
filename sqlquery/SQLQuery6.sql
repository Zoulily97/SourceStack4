--打印等腰三角形 默认设置为5行 可以将代码中5改为变量--思路:因为每行最少有一个*并且有偶数个**；而且每行有5-i个空格：而且发现每行由5个以上基本元素组成（比如：第一行由四个空格和一个*；第二行由三个空格，一个**，和一个*组成）所以@j<5 1 DECLARE @I INT,@J INT,@S VARCHAR(30)
  DECLARE @I INT,@J INT,@S VARCHAR(30)
  SET @I=1
 WHILE @I<=5
  BEGIN
   SET @S=''
   SET @J=1
   WHILE @J<5
   BEGIN 
      IF @J<=(5-@I)
     BEGIN
       SET @S=@S+' '
    END
     ELSE
     BEGIN
        SET @S=@S+'**'
     END
     SET @J=@J+1
    END
   SET @S =@S+'*'
   PRINT @S
   SET @I=@I+1
   END