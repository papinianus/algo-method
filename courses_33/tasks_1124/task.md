## 問題文

顧客情報をはじめとしたさまざまなデータを、管理したり分析するために蓄積された情報や蓄積のための仕組みをデータベース (DB) と呼びます。 特に、現在広く用いられるデータベースはリレーショナルデータベース (RDB) と呼ばれるもので、次のように構成されています。

- RDB にはいくつかのテーブル (表)が入っており、それぞれにはテーブル名がついている。
- テーブルには、1 行あたり 1 つのデータが格納される。

なお、アルゴ式では、データベースと単に呼ぶときは RDB を指すこととします。

また、データベースの具体的なイメージは、下記「データ例」を参考にしてください。

次の 3 つのテーブルからなるデータベースが与えられます。

- prefectures テーブル (都道府県の情報)
- cities テーブル (市町村+23 区の情報)
- wards テーブル (23 区以外の区の情報)

このデータベースについて、 prefectures テーブルの情報を全て表示するクエリを作成してください。

### ヒント

テーブル名が `xxxxx` のテーブルの情報を全て表示するには、次のようなクエリを書けばよいです。
`SELECT * FROM xxxxx;`

## テーブル定義

### prefectures

| 物理名     | 型   | 必須? | 初期値 | 主キー? | 備考        |
| ---------- | ---- | ----- | ------ | ------- | ----------- |
| id         | INT  | YES   | NULL   | YES     | id,一意制約 |
| name       | TEXT | NO    | NULL   | NO      | 都道府県名  |
| area       | INT  | NO    | NULL   | NO      | 面積 [km^2] |
| population | INT  | NO    | NULL   | NO      | 人口 [人]   |

### cities

| 物理名        | 型   | 必須? | 初期値 | 主キー? | 備考        |
| ------------- | ---- | ----- | ------ | ------- | ----------- |
| id            | INT  | YES   | NULL   | YES     | id,一意制約 |
| prefecture_id | INT  | NO    | NULL   | NO      | 都道府県 ID |
| name          | TEXT | NO    | NULL   | NO      | 市区町村名  |
| area          | INT  | NO    | NULL   | NO      | 面積 [km^2] |

### wards

| 物理名  | 型   | 必須? | 初期値 | 主キー? | 備考        |
| ------- | ---- | ----- | ------ | ------- | ----------- |
| id      | INT  | YES   | NULL   | YES     | id,一意制約 |
| city_id | INT  | NO    | NULL   | NO      | 市 ID       |
| name    | TEXT | NO    | NULL   | NO      | 区名        |
| area    | INT  | NO    | NULL   | NO      | 面積 [km^2] |

## データ例

### prefectures samples

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

### cities sample

| id  | prefecture_id | name     | area |
| --- | ------------- | -------- | ---- |
| 1   | 1             | 札幌市   | 1121 |
| 2   | 1             | 函館市   | 677  |
| 3   | 1             | 小樽市   | 243  |
| 4   | 1             | 旭川市   | 747  |
| 5   | 1             | 室蘭市   | 81   |
| 6   | 1             | 釧路市   | 1363 |
| 7   | 1             | 帯広市   | 619  |
| 8   | 1             | 北見市   | 1427 |
| 9   | 1             | 夕張市   | 763  |
| 10  | 1             | 岩見沢市 | 481  |
| 11  | 1             | 網走市   | 471  |
| 12  | 1             | 留萌市   | 297  |
| 13  | 1             | 苫小牧市 | 561  |
| 14  | 1             | 稚内市   | 761  |
| 15  | 1             | 美唄市   | 277  |
| 16  | 1             | 芦別市   | 865  |
| 17  | 1             | 江別市   | 187  |
| 18  | 1             | 赤平市   | 129  |
| 19  | 1             | 紋別市   | 830  |
| 20  | 1             | 士別市   | 1119 |
| 21  | 1             | 名寄市   | 535  |
| 22  | 1             | 三笠市   | 302  |
| 23  | 1             | 根室市   | 506  |
| 24  | 1             | 千歳市   | 594  |
| 25  | 1             | 滝川市   | 115  |
| 26  | 1             | 砂川市   | 78   |
| 27  | 1             | 歌志内市 | 55   |
| 28  | 1             | 深川市   | 529  |
| 29  | 1             | 富良野市 | 600  |
| 30  | 1             | 登別市   | 212  |
| 31  | 1             | 恵庭市   | 294  |
| 32  | 1             | 伊達市   | 444  |
| 33  | 1             | 北広島市 | 119  |
| 34  | 1             | 石狩市   | 722  |
| 35  | 1             | 北斗市   | 397  |
| 36  | 1             | 当別町   | 422  |
| 37  | 1             | 新篠津村 | 78   |
| 38  | 1             | 松前町   | 293  |
| 39  | 1             | 福島町   | 187  |
| 40  | 1             | 知内町   | 196  |
| 41  | 1             | 木古内町 | 221  |
| 42  | 1             | 七飯町   | 216  |
| 43  | 1             | 鹿部町   | 110  |
| 44  | 1             | 森町     | 368  |
| 45  | 1             | 八雲町   | 956  |
| 46  | 1             | 長万部町 | 310  |
| 47  | 1             | 江差町   | 109  |
| 48  | 1             | 上ノ国町 | 547  |
| 49  | 1             | 厚沢部町 | 460  |
| 50  | 1             | 乙部町   | 162  |

### wards sample

| id  | city_id | name       | area |
| --- | ------- | ---------- | ---- |
| 1   | 1       | 中央区     | 46   |
| 2   | 1       | 北区       | 63   |
| 3   | 1       | 東区       | 56   |
| 4   | 1       | 白石区     | 34   |
| 5   | 1       | 豊平区     | 46   |
| 6   | 1       | 南区       | 657  |
| 7   | 1       | 西区       | 75   |
| 8   | 1       | 厚別区     | 24   |
| 9   | 1       | 手稲区     | 56   |
| 10  | 1       | 清田区     | 59   |
| 11  | 259     | 青葉区     | 302  |
| 12  | 259     | 宮城野区   | 58   |
| 13  | 259     | 若林区     | 50   |
| 14  | 259     | 太白区     | 228  |
| 15  | 259     | 泉区       | 146  |
| 16  | 517     | 西区       | 29   |
| 17  | 517     | 北区       | 16   |
| 18  | 517     | 大宮区     | 12   |
| 19  | 517     | 見沼区     | 30   |
| 20  | 517     | 中央区     | 8    |
| 21  | 517     | 桜区       | 18   |
| 22  | 517     | 浦和区     | 11   |
| 23  | 517     | 南区       | 13   |
| 24  | 517     | 緑区       | 26   |
| 25  | 517     | 岩槻区     | 49   |
| 26  | 580     | 中央区     | 44   |
| 27  | 580     | 花見川区   | 34   |
| 28  | 580     | 稲毛区     | 21   |
| 29  | 580     | 若葉区     | 84   |
| 30  | 580     | 緑区       | 66   |
| 31  | 580     | 美浜区     | 21   |
| 32  | 696     | 鶴見区     | 33   |
| 33  | 696     | 神奈川区   | 23   |
| 34  | 696     | 西区       | 7    |
| 35  | 696     | 中区       | 21   |
| 36  | 696     | 南区       | 12   |
| 37  | 696     | 保土ケ谷区 | 21   |
| 38  | 696     | 磯子区     | 19   |
| 39  | 696     | 金沢区     | 30   |
| 40  | 696     | 港北区     | 31   |
| 41  | 696     | 戸塚区     | 35   |
| 42  | 696     | 港南区     | 19   |
| 43  | 696     | 旭区       | 32   |
| 44  | 696     | 緑区       | 25   |
| 45  | 696     | 瀬谷区     | 17   |
| 46  | 696     | 栄区       | 18   |
| 47  | 696     | 泉区       | 23   |
| 48  | 696     | 青葉区     | 35   |
| 49  | 696     | 都筑区     | 27   |
| 50  | 697     | 川崎区     | 39   |