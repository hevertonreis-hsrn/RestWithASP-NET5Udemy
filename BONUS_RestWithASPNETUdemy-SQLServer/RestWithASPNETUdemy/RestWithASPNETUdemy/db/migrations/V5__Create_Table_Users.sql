CREATE TABLE dbo.users (
  [id] bigint NOT NULL IDENTITY,
  [user_name] varchar(50) NOT NULL DEFAULT '0',
  [password] varchar(130) NOT NULL DEFAULT '0',
  [full_name] varchar(120) NOT NULL,
  [refresh_token] varchar(500) DEFAULT '0',
  [refresh_token_expiry_time] datetime2(0) DEFAULT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [user_name] UNIQUE  ([user_name])
)
GO