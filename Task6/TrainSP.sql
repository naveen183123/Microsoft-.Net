CREATE DATABASE Train;
CREATE TABLE [dbo].[Trains](
	[TrainNo] [int]  NOT NULL,
	[TrainName] [varchar](200) NULL,
 CONSTRAINT [PK_Train] PRIMARY KEY CLUSTERED 
(
	[TrainNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
CREATE PROCEDURE [dbo].[SP_Train](
 
	@ACTION			CHAR(1)      =	NULL,
	@TrainNo			INT          =	NULL,
	@TrainName		    VARCHAR(250) =	NULL
)	
AS
BEGIN
	SET NOCOUNT ON;
		IF(@ACTION='A')
		BEGIN

			SELECT * From Trains
					
		END
		ELSE IF(@ACTION='D')
		BEGIN
			DELETE FROM Trains WHERE TrainNo=@TrainNo
		END
		ELSE IF(@ACTION='E')
		BEGIN

				INSERT INTO Trains(
					TrainNo,TrainName	
					)
					VALUES (
					@TrainNo,@TrainName
					)
			END

			ELSE IF(@ACTION='G')
					BEGIN
						SELECT TrainNo,TrainName From Trains
						WHERE	TrainNo=@TrainNo
					END

	END