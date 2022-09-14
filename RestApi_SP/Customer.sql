CREATE DATABASE Customer;

CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NULL,
	[Age] [int] NULL,
	[Company] [varchar](150) NULL,
	[Email] [varchar](250) NULL,
	[Phone] [varchar](20) NULL,
	[Address] [varchar](500) NULL,
	[CreatedOn] [datetime] NULL,
 CONSTRAINT [PK_Customer_1] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE PROCEDURE [dbo].[USP_Customer](
 
	@ACTION			CHAR(1)      =	NULL,
	@CUSTID			INT          =	NULL,
	@NAME		    VARCHAR(250) =	NULL,
	@AGE       		INT          =	NULL,
	@COMPANY	    VARCHAR(350) =	NULL,
	@EMAIL			VARCHAR(250) =	NULL,
	@PHONE			VARCHAR(20)  =	NULL,
	@ADDRESS		VARCHAR(500) =	NULL
)	
AS
BEGIN
	SET NOCOUNT ON;
		IF(@ACTION='A')
		BEGIN

			SELECT CustID,Name,Age,Company,Email,Phone,Address,CreatedOn From Customer
					
		END
		ELSE IF(@ACTION='D')
		BEGIN
			DELETE FROM Customer WHERE CustID=@CUSTID
		END
		ELSE IF(@ACTION='E')
		BEGIN

			IF NOT EXISTS(SELECT 1 FROM Customer WHERE CUSTID=@CUSTID)
			BEGIN

				INSERT INTO Customer(
					Name,Age,Company,Email,Phone,[Address]		
					)
					VALUES (
					@NAME,@AGE,@COMPANY,@EMAIL,@PHONE,@ADDRESS
					)
			END
				ELSE
					BEGIN
						UPDATE Customer	SET
							Name=@Name,Age =@Age,Company=@Company ,
							Email=@Email,Phone=@Phone,Address=@Address
						
						WHERE	CustID=@CustID
			 END

			END

			ELSE IF(@ACTION='G')
					BEGIN
						SELECT CustID,Name,Age,Company,Email,Phone,Address,CreatedOn From Customer
						WHERE	CustID=@CustID
					END

	END