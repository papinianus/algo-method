## 問題文

都道府県の情報が格納されている、 prefectures テーブルのみをもつデータベースが与えられます。

prefectures テーブルに含まれる、人口が 1,000,000 人未満 の都道府県の情報を全て表示するクエリを作成してください。

### ヒント

テーブルのデータを条件で絞り込むには WHERE 句を使います。 たとえば、問題で与えられたデータベースについて、 `prefectures` テーブルから都道府県名(name カラムの値) が `東京都` のデータを表示するには次のようなクエリを書けばよいです。
`SELECT * FROM prefectures WHERE name = "東京都";`

WHERE 句を用いると、不等式 (以上/以下) や部分一致など、さまざまな条件でデータを絞り込むことが可能です。 書き方のわからない条件がある場合は適宜検索しながら使用しましょう。

## テーブル定義

| 物理名     | 型   | 必須? | 初期値 | 主キー? | 備考        |
| ---------- | ---- | ----- | ------ | ------- | ----------- |
| id         | INT  | YES   | NULL   | YES     | id,一意制約 |
| name       | TEXT | NO    | NULL   | NO      | 都道府県名  |
| area       | INT  | NO    | NULL   | NO      | 面積 [km^2] |
| population | INT  | NO    | NULL   | NO      | 人口 [人]   |

## データ例

| id  | name     | area  | population |
| --- | -------- | ----- | ---------- |
| 1   | 北海道   | 83423 | 5225000    |
| 2   | 青森県   | 9645  | 1238000    |
| 3   | 岩手県   | 15275 | 1211000    |
| 4   | 宮城県   | 7282  | 2302000    |
| 5   | 秋田県   | 11637 | 960000     |
| 6   | 山形県   | 9323  | 1068000    |
| 7   | 福島県   | 13784 | 1833000    |
| 8   | 茨城県   | 6097  | 2867000    |
| 9   | 栃木県   | 6408  | 1933000    |
| 10  | 群馬県   | 6362  | 1939000    |
| 11  | 埼玉県   | 3797  | 7345000    |
| 12  | 千葉県   | 5156  | 6284000    |
| 13  | 東京都   | 2194  | 14048000   |
| 14  | 神奈川県 | 2416  | 9237000    |
| 15  | 新潟県   | 12583 | 2201000    |
| 16  | 富山県   | 4247  | 1035000    |
| 17  | 石川県   | 4186  | 1133000    |
| 18  | 福井県   | 4190  | 767000     |
| 19  | 山梨県   | 4465  | 810000     |
| 20  | 長野県   | 13561 | 2048000    |
| 21  | 岐阜県   | 10621 | 1979000    |
| 22  | 静岡県   | 7777  | 3633000    |
| 23  | 愛知県   | 5173  | 7542000    |
| 24  | 三重県   | 5774  | 1770000    |
| 25  | 滋賀県   | 4017  | 1414000    |
| 26  | 京都府   | 4612  | 2578000    |
| 27  | 大阪府   | 1905  | 8838000    |
| 28  | 兵庫県   | 8400  | 5465000    |
| 29  | 奈良県   | 3690  | 1324000    |
| 30  | 和歌山県 | 4724  | 923000     |
| 31  | 鳥取県   | 3507  | 553000     |
| 32  | 島根県   | 6707  | 671000     |
| 33  | 岡山県   | 7114  | 1888000    |
| 34  | 広島県   | 8479  | 2800000    |
| 35  | 山口県   | 6112  | 1342000    |
| 36  | 徳島県   | 4146  | 720000     |
| 37  | 香川県   | 1876  | 950000     |
| 38  | 愛媛県   | 5675  | 1335000    |
| 39  | 高知県   | 7102  | 692000     |
| 40  | 福岡県   | 4987  | 5135000    |
| 41  | 佐賀県   | 2440  | 811000     |
| 42  | 長崎県   | 4130  | 1312000    |
| 43  | 熊本県   | 7409  | 1738000    |
| 44  | 大分県   | 6340  | 1124000    |
| 45  | 宮崎県   | 7734  | 1070000    |
| 46  | 鹿児島県 | 9186  | 1588000    |
| 47  | 沖縄県   | 2282  | 1467000    |
