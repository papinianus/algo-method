WITH
    `expenses`
    AS (
        SELECT * FROM `expenses_april`
        UNION ALL SELECT * FROM `expenses_may`
        UNION ALL SELECT * FROM `expenses_june`)
SELECT
    `category` AS 'カテゴリ',
    SUM(`amount`) AS '支出額'
FROM `expenses`
    GROUP BY `category`
    ORDER BY `支出額` DESC;