## 問題文

正の整数 N,M が与えられます。

3 つの正の整数の組 x,y,z であって、

- x,y,z はそれぞれ 1 以上 N 以下の整数である
- x,y,z の総和は M 以下である

という条件をともに満たすものが何個あるかを求めてください。

### ヒント

- z のループは不要

比較的すぐに思いつく解法は、x,y,z をすべて調べる方法かもしれません。 しかしその方法では O(N3) の計算量となります (考えてみてください)。 O(N3) の解法では「時間切れ」となりますので、工夫が必要です。

実は、x,y をすべて調べるだけでこの問題は解けます。 x,y の値を決めると、z のとりうる値の範囲は自動的に決まります。 これによって、O(N2) の解法にすることができます。

## 入力

入力は次の形式で与えられます。

```text
N M
```

また、入力される値は次の制約を満たします。

- N は 1 以上 2000 以下の整数
- M は 1 以上 3N 以下の整数

## 出力

答えを出力してください。

## 入出力例

### 入力例 1

```text
2 4
```

### 出力例 1

```text
4
```

条件を満たす x,y,z は次の 4 つです。

- (x,y,z)=(1,1,1)
- (x,y,z)=(1,1,2)
- (x,y,z)=(1,2,1)
- (x,y,z)=(2,1,1)

### 入力例 2

```text
1000 2022
```

### 出力例 2

```text
843614540
```