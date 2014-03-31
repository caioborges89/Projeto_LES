IF EXISTS (SELECT * FROM sys.syslogins WHERE name = 'user_beauty')
	                                            BEGIN
		                                            DROP LOGIN user_beauty
	                                            END

                                            CREATE LOGIN [user_beauty] WITH PASSWORD=N'1234abcd', 
	                                            DEFAULT_DATABASE=[BD_BEAUTY], 
	                                            DEFAULT_LANGUAGE=[us_english], 
	                                            CHECK_EXPIRATION=OFF, 
	                                            CHECK_POLICY=OFF
                                            	

                                            DECLARE 
                                            @NAME VARCHAR(150),
                                            @SQL VARCHAR(MAX)

                                            DECLARE  CUR CURSOR FOR 
                                            select name from sys.databases where 
                                            name = 'BD_BEAUTY'

                                            OPEN CUR

                                            FETCH NEXT FROM CUR 
                                            INTO @NAME

                                            WHILE @@FETCH_STATUS = 0
                                            BEGIN 

	                                            SET @SQL = 'USE [' +@NAME + ']
                                            							
				                                            if  ISNULL((select USER_ID(''USER_BEAUTY'')),-1) <> -1
				                                            BEGIN
					                                            DROP USER [USER_BEAUTY]
				                                            END'
	                                            EXEC (@SQL)
                                            	
	                                            SET @SQL = 'USE [' +@NAME + '] 
				                                            CREATE USER [user_beauty] FOR LOGIN [user_beauty] WITH DEFAULT_SCHEMA=[dbo]
				                                            EXEC sp_addrolemember N''db_owner'', N''user_beauty'' '
                                            				
	                                            EXEC (@SQL)
                                            	
	                                            FETCH NEXT FROM CUR 
	                                            INTO @NAME
                                            END

                                            CLOSE CUR
                                            DEALLOCATE CUR