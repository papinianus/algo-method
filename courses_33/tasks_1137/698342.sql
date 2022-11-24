SELECT
 `name` AS '都道府県名',
 (SELECT `name` FROM `regions` WHERE `region_id` = `id`) AS '地方名'
FROM `prefectures`;