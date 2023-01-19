## 問題文

カメのアルルたちは一定期間内に様々な課題に挑戦できる、インターネット上のイベントに参加しました。 このイベントでは、参加者ごとに挑戦した課題の合計点が集計され、その合計点が高い 10 名に景品が授与されます。

---

このイベントにおける課題の挑戦結果が `results` テーブルに与えられます。

また、一部の挑戦結果を集計に使わないで欲しいと参加者が申し出ています。このオプトアウト情報が `optout` テーブルに与えられます。 `optout` テーブルの `email`, `game_id`, `score` の組は、それと同じ組を持つレコードが `results` テーブルに存在することが保証されます。(`id` は異なる可能性があります。)

これらのテーブルから、集計対象の結果のみをもとにして合計点を集計し、 景品授与対象 (合計点の上位 10 名) のメールアドレスを取得して表示するクエリを作成してください。

ただし、このメールアドレスが格納されるカラムのカラム名は `email` としてください。

### ヒント 1. 差分を取得する

複数のクエリの結果から差分を抽出したいときには `EXCEPT` 演算子を使います。 たとえば、同じ構成のテーブル `aaa` と `bbb` があり、`aaa` にはあって `bbb` にないデータを出力するには次のようなクエリを書けばよいです。
`SELECT _ FROM aaa EXCEPT SELECT _ FROM bbb;`

このとき、`EXCEPT` で結ばれた複数のクエリは、実行結果のフォーマット (カラムの数や順番、それぞれのデータ型) が一致していないといけません。

## results テーブル定義

| 物理名   | 型   | 必須? | 初期値 | 主キー? | 備考               |
| -------- | ---- | ----- | ------ | ------- | ------------------ |
| id       | INT  | YES   | NULL   | YES     | id                 |
| 一意制約 |      |       |        |         |                    |
| email    | TEXT | NO    | NULL   | NO      | 登録メールアドレス |
| game_id  | INT  | NO    | NULL   | NO      | 参加したゲーム ID  |
| score    | INT  | NO    | NULL   | NO      | スコア             |

## results データ例

| id  | email                    | game_id | score |
| --- | ------------------------ | ------- | ----- |
| 1   | oruru.cb@algo-method.com | 101     | 93718 |
| 2   | iroro.cl@algo-method.com | 101     | 13154 |
| 3   | oriri.ki@algo-method.com | 105     | 92260 |
| 4   | urere.uk@algo-method.com | 108     | 13833 |
| 5   | eruru.fd@algo-method.com | 108     | 70592 |
| 6   | oruru.td@algo-method.com | 105     | 40319 |
| 7   | oriri.ki@algo-method.com | 109     | 90964 |
| 8   | erere.fx@algo-method.com | 107     | 92459 |
| 9   | irara.yo@algo-method.com | 102     | 72340 |
| 10  | oruru.wp@algo-method.com | 105     | 16683 |
| 11  | iruru.wv@algo-method.com | 101     | 56207 |
| 12  | iriri.ue@algo-method.com | 105     | 64923 |
| 13  | uroro.gk@algo-method.com | 110     | 38652 |
| 14  | ariri.gq@algo-method.com | 103     | 64038 |
| 15  | arere.ln@algo-method.com | 107     | 15194 |
| 16  | erere.or@algo-method.com | 103     | 70798 |
| 17  | uriri.lw@algo-method.com | 102     | 45293 |
| 18  | iroro.cc@algo-method.com | 108     | 52386 |
| 19  | ororo.vq@algo-method.com | 107     | 40538 |
| 20  | oriri.jo@algo-method.com | 105     | 47739 |
| 21  | oruru.wp@algo-method.com | 101     | 52743 |
| 22  | iroro.cl@algo-method.com | 105     | 59890 |
| 23  | oruru.wp@algo-method.com | 108     | 87153 |
| 24  | arere.ln@algo-method.com | 104     | 41224 |
| 25  | arere.gy@algo-method.com | 107     | 23053 |
| 26  | iroro.nw@algo-method.com | 110     | 47012 |
| 27  | iriri.yi@algo-method.com | 103     | 45830 |
| 28  | urara.kp@algo-method.com | 102     | 59245 |
| 29  | orara.ce@algo-method.com | 101     | 83819 |
| 30  | uriri.fs@algo-method.com | 102     | 58138 |
| 31  | oriri.cm@algo-method.com | 106     | 9329  |
| 32  | arara.jf@algo-method.com | 101     | 75454 |
| 33  | eruru.fd@algo-method.com | 102     | 76931 |
| 34  | uriri.lf@algo-method.com | 105     | 76955 |
| 35  | irere.mu@algo-method.com | 107     | 97609 |
| 36  | irara.us@algo-method.com | 106     | 23509 |
| 37  | eroro.hq@algo-method.com | 110     | 16591 |
| 38  | iroro.ay@algo-method.com | 110     | 77139 |
| 39  | uriri.lf@algo-method.com | 101     | 11970 |
| 40  | urere.fh@algo-method.com | 103     | 76019 |
| 41  | ororo.xg@algo-method.com | 104     | 42437 |
| 42  | aroro.kb@algo-method.com | 110     | 70701 |
| 43  | ororo.zn@algo-method.com | 106     | 40888 |
| 44  | erere.or@algo-method.com | 107     | 30311 |
| 45  | uroro.ob@algo-method.com | 108     | 47049 |
| 46  | urara.cq@algo-method.com | 110     | 48571 |
| 47  | uriri.cg@algo-method.com | 102     | 67000 |
| 48  | urere.gw@algo-method.com | 108     | 79129 |
| 49  | uriri.fs@algo-method.com | 105     | 42219 |
| 50  | arara.zq@algo-method.com | 103     | 53955 |

## optout テーブル定義

| 物理名   | 型   | 必須? | 初期値 | 主キー? | 備考               |
| -------- | ---- | ----- | ------ | ------- | ------------------ |
| id       | INT  | YES   | NULL   | YES     | id                 |
| 一意制約 |      |       |        |         |                    |
| email    | TEXT | NO    | NULL   | NO      | 登録メールアドレス |
| game_id  | INT  | NO    | NULL   | NO      | 参加したゲーム ID  |
| score    | INT  | NO    | NULL   | NO      | スコア             |

## optout データ例

| id  | email                    | game_id | score |
| --- | ------------------------ | ------- | ----- |
| 1   | oriri.ki@algo-method.com | 109     | 90964 |
| 2   | irara.yo@algo-method.com | 102     | 72340 |
| 3   | oruru.wp@algo-method.com | 101     | 52743 |
| 4   | oriri.cm@algo-method.com | 106     | 9329  |
| 5   | ariri.df@algo-method.com | 101     | 86200 |
| 6   | irara.yo@algo-method.com | 110     | 31300 |
| 7   | oruru.td@algo-method.com | 109     | 37828 |
| 8   | orere.pr@algo-method.com | 110     | 36342 |
| 9   | erara.wg@algo-method.com | 108     | 30217 |
| 10  | orara.sr@algo-method.com | 106     | 82155 |
| 11  | aruru.jz@algo-method.com | 110     | 44396 |
| 12  | ururu.rh@algo-method.com | 109     | 85316 |
| 13  | erara.bq@algo-method.com | 110     | 15396 |
| 14  | aroro.es@algo-method.com | 102     | 41588 |
| 15  | iroro.nw@algo-method.com | 108     | 71364 |
| 16  | irara.fy@algo-method.com | 110     | 87670 |
| 17  | uriri.bj@algo-method.com | 102     | 60258 |
| 18  | orara.us@algo-method.com | 110     | 75574 |
| 19  | aruru.ka@algo-method.com | 103     | 79276 |
| 20  | ururu.fi@algo-method.com | 102     | 64451 |
| 21  | eriri.yz@algo-method.com | 104     | 34362 |
| 22  | ororo.xg@algo-method.com | 107     | 34782 |
| 23  | uroro.zn@algo-method.com | 104     | 60931 |
| 24  | eriri.qo@algo-method.com | 108     | 4722  |
| 25  | ororo.vq@algo-method.com | 105     | 39363 |
| 26  | uriri.lw@algo-method.com | 105     | 83746 |
| 27  | ariri.mf@algo-method.com | 107     | 4373  |
| 28  | oriri.jo@algo-method.com | 103     | 87900 |
| 29  | eroro.fp@algo-method.com | 101     | 72420 |
| 30  | iruru.lm@algo-method.com | 107     | 90794 |
| 31  | iroro.xl@algo-method.com | 102     | 34099 |
| 32  | aruru.ff@algo-method.com | 104     | 15915 |
| 33  | eruru.ig@algo-method.com | 107     | 97978 |
| 34  | eroro.fa@algo-method.com | 108     | 49857 |
| 35  | ururu.rh@algo-method.com | 105     | 12999 |
| 36  | oriri.gd@algo-method.com | 109     | 17275 |
| 37  | iriri.ue@algo-method.com | 103     | 85461 |
| 38  | iruru.wp@algo-method.com | 105     | 23405 |
| 39  | ororo.wg@algo-method.com | 109     | 19080 |
| 40  | iroro.nw@algo-method.com | 101     | 58115 |
| 41  | irere.ot@algo-method.com | 110     | 54379 |
| 42  | aroro.kb@algo-method.com | 108     | 26318 |
| 43  | ororo.bt@algo-method.com | 107     | 29466 |
| 44  | urere.fh@algo-method.com | 110     | 88555 |
| 45  | ururu.zw@algo-method.com | 108     | 79997 |
| 46  | erara.bq@algo-method.com | 108     | 14871 |
| 47  | irara.zp@algo-method.com | 109     | 59459 |
| 48  | orara.sr@algo-method.com | 105     | 41505 |
| 49  | ororo.xg@algo-method.com | 108     | 6868  |
| 50  | orere.nz@algo-method.com | 107     | 68146 |
