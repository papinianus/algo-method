## 問題文

カメのアルルは 3 日間開催されるイベントに参加しました。 このイベントは各日出し物が異なるため、参加者は興味にあわせて出し物ごとに参加登録をします。

---

このイベントの 1 日目 から 3 日目の参加登録情報が、それぞれ `registrations_day1`, `registrations_day2`, `registrations_day3` テーブルとして与えられます。

イベントに 3 日とも登録した参加者のメールアドレスを全て取得して表示するクエリを作成してください。

ただし、このメールアドレスが格納されるカラムのカラム名は `email` としてください。

### ヒント 1. 複数の取得結果の重複部分をまとめる

複数のクエリの結果から重複したレコードだけを抽出したいときには `INTERSECT` 演算子を使います。 たとえば、同じ構成のテーブル `aaa` と `bbb` から重複したデータを出力するには次のようなクエリを書けばよいです。

```sql
SELECT _ FROM aaa INTERSECT SELECT _ FROM bbb;
```

このとき、`INTERSECT` で結ばれた複数のクエリは、実行結果のフォーマット (カラムの数や順番、それぞれのデータ型) が一致していないといけません。

## テーブル定義(共通)

| 物理名   | 型   | 必須? | 初期値 | 主キー? | 備考               |
| -------- | ---- | ----- | ------ | ------- | ------------------ |
| id       | INT  | YES   | NULL   | YES     | id                 |
| 一意制約 |      |       |        |         |                    |
| email    | TEXT | NO    | NULL   | NO      | 登録メールアドレス |
| event_id | INT  | NO    | NULL   | NO      | セミナー ID        |
| date     | date | NO    | NULL   | NO      | 登録日             |

## registrations_day1 データ例

| id  | email                    | event_id | date       |
| --- | ------------------------ | -------- | ---------- |
| 1   | arara.qa@algo-method.com | 106      | 2022-10-01 |
| 2   | iriri.yi@algo-method.com | 109      | 2022-10-01 |
| 3   | erere.af@algo-method.com | 301      | 2022-10-01 |
| 4   | oruru.td@algo-method.com | 101      | 2022-10-02 |
| 5   | oruru.pq@algo-method.com | 101      | 2022-10-02 |
| 6   | oruru.td@algo-method.com | 102      | 2022-10-02 |
| 7   | urara.sb@algo-method.com | 102      | 2022-10-02 |
| 8   | uriri.lf@algo-method.com | 104      | 2022-10-02 |
| 9   | eriri.vu@algo-method.com | 106      | 2022-10-02 |
| 10  | iriri.ai@algo-method.com | 102      | 2022-10-03 |
| 11  | oruru.pq@algo-method.com | 106      | 2022-10-03 |
| 12  | iroro.xl@algo-method.com | 107      | 2022-10-03 |
| 13  | urere.fh@algo-method.com | 108      | 2022-10-03 |
| 14  | ororo.xg@algo-method.com | 104      | 2022-10-04 |
| 15  | orere.zc@algo-method.com | 108      | 2022-10-04 |
| 16  | eruru.va@algo-method.com | 105      | 2022-10-05 |
| 17  | aruru.ka@algo-method.com | 108      | 2022-10-05 |
| 18  | irere.ie@algo-method.com | 109      | 2022-10-05 |
| 19  | eroro.os@algo-method.com | 201      | 2022-10-05 |
| 20  | urara.kp@algo-method.com | 101      | 2022-10-06 |
| 21  | ororo.bt@algo-method.com | 105      | 2022-10-06 |
| 22  | arere.rn@algo-method.com | 105      | 2022-10-06 |
| 23  | ororo.zn@algo-method.com | 108      | 2022-10-06 |
| 24  | orere.wy@algo-method.com | 109      | 2022-10-06 |
| 25  | aroro.es@algo-method.com | 109      | 2022-10-07 |
| 26  | arara.zq@algo-method.com | 301      | 2022-10-07 |
| 27  | arere.ln@algo-method.com | 101      | 2022-10-09 |
| 28  | ororo.vq@algo-method.com | 102      | 2022-10-09 |
| 29  | irere.un@algo-method.com | 102      | 2022-10-09 |
| 30  | ororo.vq@algo-method.com | 106      | 2022-10-09 |
| 31  | aruru.ka@algo-method.com | 109      | 2022-10-09 |
| 32  | ororo.bt@algo-method.com | 301      | 2022-10-09 |
| 33  | ariri.gq@algo-method.com | 101      | 2022-10-10 |
| 34  | arara.jf@algo-method.com | 103      | 2022-10-10 |
| 35  | iruru.ey@algo-method.com | 107      | 2022-10-10 |
| 36  | arere.rn@algo-method.com | 107      | 2022-10-10 |
| 37  | uriri.cg@algo-method.com | 109      | 2022-10-10 |
| 38  | irere.un@algo-method.com | 101      | 2022-10-11 |
| 39  | oriri.jo@algo-method.com | 101      | 2022-10-12 |
| 40  | erere.ne@algo-method.com | 103      | 2022-10-12 |
| 41  | irere.mu@algo-method.com | 105      | 2022-10-12 |
| 42  | urara.kp@algo-method.com | 107      | 2022-10-12 |
| 43  | ururu.fi@algo-method.com | 102      | 2022-10-13 |
| 44  | orere.px@algo-method.com | 103      | 2022-10-13 |
| 45  | uroro.gk@algo-method.com | 105      | 2022-10-13 |
| 46  | ororo.zn@algo-method.com | 106      | 2022-10-13 |
| 47  | iroro.nw@algo-method.com | 107      | 2022-10-13 |
| 48  | iriri.ue@algo-method.com | 109      | 2022-10-13 |
| 49  | arara.zy@algo-method.com | 101      | 2022-10-14 |
| 50  | eruru.eh@algo-method.com | 102      | 2022-10-14 |

## registrations_day2 データ例

| id  | email                    | event_id | date       |
| --- | ------------------------ | -------- | ---------- |
| 1   | oriri.ki@algo-method.com | 205      | 2022-10-01 |
| 2   | arere.hf@algo-method.com | 110      | 2022-10-02 |
| 3   | iroro.nw@algo-method.com | 205      | 2022-10-02 |
| 4   | uriri.fs@algo-method.com | 206      | 2022-10-02 |
| 5   | urara.sb@algo-method.com | 208      | 2022-10-02 |
| 6   | orere.px@algo-method.com | 209      | 2022-10-02 |
| 7   | ariri.tr@algo-method.com | 210      | 2022-10-02 |
| 8   | oruru.pq@algo-method.com | 106      | 2022-10-03 |
| 9   | orara.sr@algo-method.com | 202      | 2022-10-03 |
| 10  | arara.as@algo-method.com | 204      | 2022-10-03 |
| 11  | ororo.vq@algo-method.com | 206      | 2022-10-03 |
| 12  | ururu.rh@algo-method.com | 203      | 2022-10-04 |
| 13  | aroro.es@algo-method.com | 205      | 2022-10-04 |
| 14  | ororo.xg@algo-method.com | 110      | 2022-10-05 |
| 15  | eroro.fa@algo-method.com | 202      | 2022-10-05 |
| 16  | eriri.xw@algo-method.com | 203      | 2022-10-05 |
| 17  | urara.cq@algo-method.com | 204      | 2022-10-05 |
| 18  | orara.og@algo-method.com | 206      | 2022-10-05 |
| 19  | eruru.va@algo-method.com | 302      | 2022-10-05 |
| 20  | aroro.es@algo-method.com | 210      | 2022-10-06 |
| 21  | eroro.fa@algo-method.com | 204      | 2022-10-07 |
| 22  | iriri.ue@algo-method.com | 210      | 2022-10-07 |
| 23  | iroro.cc@algo-method.com | 302      | 2022-10-07 |
| 24  | irere.un@algo-method.com | 205      | 2022-10-08 |
| 25  | orere.px@algo-method.com | 210      | 2022-10-08 |
| 26  | iriri.bp@algo-method.com | 210      | 2022-10-09 |
| 27  | orere.nz@algo-method.com | 302      | 2022-10-09 |
| 28  | irara.zp@algo-method.com | 110      | 2022-10-10 |
| 29  | uroro.ch@algo-method.com | 206      | 2022-10-10 |
| 30  | aruru.ff@algo-method.com | 210      | 2022-10-10 |
| 31  | erere.or@algo-method.com | 202      | 2022-10-11 |
| 32  | ororo.xg@algo-method.com | 202      | 2022-10-11 |
| 33  | ororo.zn@algo-method.com | 203      | 2022-10-11 |
| 34  | oriri.gd@algo-method.com | 203      | 2022-10-11 |
| 35  | urara.kp@algo-method.com | 204      | 2022-10-11 |
| 36  | arara.qa@algo-method.com | 208      | 2022-10-11 |
| 37  | erara.gu@algo-method.com | 210      | 2022-10-11 |
| 38  | eriri.wb@algo-method.com | 204      | 2022-10-12 |
| 39  | erara.wg@algo-method.com | 206      | 2022-10-12 |
| 40  | oruru.cb@algo-method.com | 205      | 2022-10-13 |
| 41  | ariri.qp@algo-method.com | 110      | 2022-10-14 |
| 42  | erara.bq@algo-method.com | 204      | 2022-10-14 |
| 43  | erere.fx@algo-method.com | 205      | 2022-10-14 |
| 44  | ururu.rh@algo-method.com | 210      | 2022-10-14 |
| 45  | erara.gu@algo-method.com | 202      | 2022-10-15 |
| 46  | urara.kh@algo-method.com | 202      | 2022-10-15 |
| 47  | aruru.ej@algo-method.com | 203      | 2022-10-15 |
| 48  | irere.wi@algo-method.com | 205      | 2022-10-15 |
| 49  | erara.bq@algo-method.com | 207      | 2022-10-15 |
| 50  | aruru.jz@algo-method.com | 210      | 2022-10-15 |

## registrations_day3 データ例

| id  | email                    | event_id | date       |
| --- | ------------------------ | -------- | ---------- |
| 1   | uroro.ob@algo-method.com | 304      | 2022-10-01 |
| 2   | urara.kh@algo-method.com | 307      | 2022-10-01 |
| 3   | uriri.lf@algo-method.com | 308      | 2022-10-01 |
| 4   | arere.hf@algo-method.com | 110      | 2022-10-02 |
| 5   | iroro.nw@algo-method.com | 205      | 2022-10-02 |
| 6   | erara.zq@algo-method.com | 305      | 2022-10-02 |
| 7   | urere.fh@algo-method.com | 304      | 2022-10-03 |
| 8   | arara.qa@algo-method.com | 305      | 2022-10-03 |
| 9   | irere.ot@algo-method.com | 306      | 2022-10-04 |
| 10  | oriri.ki@algo-method.com | 307      | 2022-10-04 |
| 11  | urara.cq@algo-method.com | 204      | 2022-10-05 |
| 12  | orara.og@algo-method.com | 206      | 2022-10-05 |
| 13  | iroro.cc@algo-method.com | 211      | 2022-10-05 |
| 14  | urara.mo@algo-method.com | 305      | 2022-10-05 |
| 15  | eroro.fp@algo-method.com | 305      | 2022-10-05 |
| 16  | erara.zq@algo-method.com | 306      | 2022-10-05 |
| 17  | aruru.ff@algo-method.com | 306      | 2022-10-05 |
| 18  | arara.zq@algo-method.com | 308      | 2022-10-05 |
| 19  | eriri.yz@algo-method.com | 308      | 2022-10-05 |
| 20  | aroro.es@algo-method.com | 210      | 2022-10-06 |
| 21  | aruru.jz@algo-method.com | 304      | 2022-10-06 |
| 22  | erara.gu@algo-method.com | 305      | 2022-10-06 |
| 23  | erara.fn@algo-method.com | 303      | 2022-10-07 |
| 24  | aroro.es@algo-method.com | 305      | 2022-10-07 |
| 25  | iriri.bp@algo-method.com | 309      | 2022-10-07 |
| 26  | irara.zp@algo-method.com | 211      | 2022-10-08 |
| 27  | urara.kp@algo-method.com | 303      | 2022-10-08 |
| 28  | urere.uk@algo-method.com | 311      | 2022-10-08 |
| 29  | iriri.ai@algo-method.com | 111      | 2022-10-09 |
| 30  | eruru.va@algo-method.com | 305      | 2022-10-09 |
| 31  | oriri.gd@algo-method.com | 309      | 2022-10-09 |
| 32  | oruru.td@algo-method.com | 304      | 2022-10-10 |
| 33  | aroro.xc@algo-method.com | 306      | 2022-10-10 |
| 34  | oriri.gd@algo-method.com | 203      | 2022-10-11 |
| 35  | oriri.gd@algo-method.com | 304      | 2022-10-11 |
| 36  | oriri.cm@algo-method.com | 305      | 2022-10-11 |
| 37  | orara.og@algo-method.com | 308      | 2022-10-11 |
| 38  | urara.mo@algo-method.com | 308      | 2022-10-11 |
| 39  | aruru.ff@algo-method.com | 308      | 2022-10-11 |
| 40  | aroro.xc@algo-method.com | 311      | 2022-10-11 |
| 41  | eriri.yz@algo-method.com | 304      | 2022-10-12 |
| 42  | ororo.zn@algo-method.com | 306      | 2022-10-12 |
| 43  | orere.pr@algo-method.com | 309      | 2022-10-12 |
| 44  | uriri.lf@algo-method.com | 310      | 2022-10-12 |
| 45  | iriri.rk@algo-method.com | 304      | 2022-10-13 |
| 46  | uroro.os@algo-method.com | 307      | 2022-10-13 |
| 47  | eriri.qo@algo-method.com | 308      | 2022-10-14 |
| 48  | eruru.va@algo-method.com | 303      | 2022-10-15 |
| 49  | oriri.jo@algo-method.com | 304      | 2022-10-15 |
| 50  | orara.us@algo-method.com | 305      | 2022-10-15 |
