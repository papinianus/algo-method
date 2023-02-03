## 問題文

カメのアルルはお店にアイスを買いにきました。 このアイスは食べ終わった M 本の棒をまとめてお店に持っていくと、 新たなアイス 1 本に無料で引き換えてもらえます。

アルルが N 本のアイスを買うとき、最大で何本のアイスを食べることができますか。 ただし、アルルははじめアイスの棒を 1 本も持っていません。
入力

入力は次の形式で与えられます。

```text
N M
```

また、入力される値は次の制約を満たします。

- N は 1 以上 100 以下の整数
- M は 2 以上 10 以下の整数

## 出力

答えを出力してください。

## 入出力例

### 入力例 1

```text
5 3
```

### 出力例 1

```text
7
```

アルルは 5 本のアイスを買いました。

- 買ったアイスを全て食べると 5 本のアイスの棒が手に入ります。
- このうち 3 本のアイスの棒をお店に持っていくことで 1 本無料でアイスをもらえます。
- このアイスを食べるとアルルの手元には 5−3+1=3 本のアイスの棒が残るので、もう一度 3 本のアイスの棒をお店に持っていくことで再び 1 本無料でアイスをもらえます。
- このアイスを食べるとアルルはアイスの棒を 3−3+1=1 本だけ持っていることになるので、これ以上の交換はできません。

以上より、アルルは最大で 5+1+1=7 本のアイスを食べることができます。

### 入力例 2

```text
9 10
```

### 出力例 2

```text
9
```

一度も交換できない場合もあります。