CREATE TABLE [dbo].[Station](
	[TrainNo] [int]  NOT NULL,
	[StationNo] [int] NOT NULL,
	[StationName] [varchar](250) NULL,
	[Date] [varchar](150) NULL,
	[ArrivalTime] [varchar](250) NULL,
	[DepatureTime] [varchar](20) NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[TrainNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
CREATE PROCEDURE [dbo].[SP_Station](
 
	@ACTION			CHAR(1)      =	NULL,
	@TrainNo			INT          =	NULL,
	@StationNo		INT			=NULL,
	@StationName		    VARCHAR(250) =	NULL,
	@DATE	    VARCHAR(350) =	NULL,
	@ArrivalTime			VARCHAR(250) =	NULL,
	@DepatureTime			VARCHAR(20)  =	NULL
	)	
AS
BEGIN
	SET NOCOUNT ON;
		IF(@ACTION='A')
		BEGIN

			SELECT * From Station
					
		END
		ELSE IF(@ACTION='D')
		BEGIN
			DELETE FROM Station WHERE StationNo=@StationNo
		END
		ELSE IF(@ACTION='E')
		BEGIN

			INSERT INTO Station(
					TrainNo,StationNo,StationName,Date,ArrivalTime,DepatureTime		
					)
					VALUES (
					@TrainNo,@StationNo,@StationName,@DATE,@ArrivalTime,@DepatureTime
					)

			END

			ELSE IF(@ACTION='G')
					BEGIN
						SELECT TrainNo,StationName,Date,ArrivalTime,DepatureTime From Station
						WHERE	StationNo=@StationNo
					END
			ELSE IF(@ACTION='X')
					BEGIN
						Select TrainNo from Station WHERE StationName=@StationName and ArrivalTime=@ArrivalTime;
					END
			ELSE IF(@ACTION='Z')
					BEGIN
						SELECT StationName FROM Station Where TrainNo=@TrainNo AND ArrivalTime=@ArrivalTime;
					END
			ELSE IF(@ACTION='V')
					BEGIN
						SELECT TrainNo,Date FROM Station Where Date=@DATE;
					END

	END