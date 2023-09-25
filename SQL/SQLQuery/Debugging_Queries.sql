SELECT sum(o.[Total Excluding Tax]) as Total,d.[calendar year]

from Fact.[Order] o join Dimension.Date d on o.[Order Date Key] = d.Date

group by d.[calendar year]