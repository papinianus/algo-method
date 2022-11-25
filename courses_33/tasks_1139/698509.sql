-- 内陸県を取得する SELECT 文のサブクエリ作成
WITH
    inland_prefectures
AS (
    -- ここに適切なクエリを記述してください
    SELECT
        *
    FROM
        `prefectures`
        WHERE
            `name` in ('栃木県', '群馬県', '埼玉県', '山梨県','長野県', '岐阜県', '滋賀県', '奈良県')
    )
-- 内陸県のデータを面積が大きい順に表示
SELECT
    *
FROM
    inland_prefectures
ORDER BY
    area DESC;