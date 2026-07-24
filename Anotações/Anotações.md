# 📘 C# - Anotações Básicas

## C# é uma linguagem fortemente tipada

- **Dados:** Informações.
- **Variáveis:** Espaço utilizado para armazenar dados.
- **`=`:** Operador de atribuição.
- **`+`:** Soma de números ou concatenação de strings.

---

# Tipos de Dados

| Tipo | Exemplo | Descrição |
|------|---------|-----------|
| `int` | `1`, `-5`, `100` | Números inteiros |
| `double` | `2.85`, `1.73` | Números decimais |
| `string` | `"SENAI"` | Texto |
| `char` | `'A'` | Um único caractere |
| `bool` | `true`, `false` | Valor lógico |

```csharp
int numero = 10;
double preco = 29.99;
string escola = "SENAI";
char letra = 'A';
bool aprovado = true;
```

---

# Saída de Dados

```csharp
Console.WriteLine("Texto"); // Escreve e pula linha
Console.Write("Texto");      // Escreve na mesma linha
```

Com `using static System.Console;`:

```csharp
WriteLine("Texto");
Write("Texto");
```

---

# Entrada de Dados

```csharp
Console.ReadLine(); // Lê uma linha digitada pelo usuário
ReadKey();          // Aguarda uma tecla ser pressionada
```

---

# Sequências de Escape

| Escape | Significado |
|---------|-------------|
| `\n` | Nova linha |
| `\t` | Tabulação |
| `\r` | Retorno do cursor |
| `\b` | Backspace |
| `\f` | Form Feed |
| `\v` | Tabulação vertical |
| `\\` | Barra invertida |
| `\'` | Aspas simples |
| `\"` | Aspas duplas |
| `\0` | Caractere nulo |

Exemplo:

```csharp
WriteLine("Primeira linha\nSegunda linha");
WriteLine("Nome\tIdade");
```

---

# Interpolação de Strings

Utiliza `$` para inserir variáveis dentro do texto.

```csharp
string escola = "SENAI";
WriteLine($"Escola: {escola}");
```

---

# Configuração do Console

## Alterar o título

```csharp
Title = "SENAI | BACKEND";
```

## Emitir um som

```csharp
Beep(500, 500);
```

- Primeiro valor: frequência (Hz)
- Segundo valor: duração (ms)

---

## Alterar cores

```csharp
BackgroundColor = ConsoleColor.DarkBlue;
ForegroundColor = ConsoleColor.Green;

WriteLine("SENAI | BACKEND");

BackgroundColor = ConsoleColor.Black;
ForegroundColor = ConsoleColor.White;
```

---

# Formatação Numérica

```csharp
double numero = 1.787654321;

WriteLine($"{numero:n}");
```

Saída:

```
1,79
```

Outros formatos:

```csharp
WriteLine($"{numero:f2}"); // 2 casas decimais
WriteLine($"{numero:p}");  // Percentual
WriteLine($"{numero:c}");  // Moeda
```

---

# Operadores Aritméticos

| Operador | Descrição |
|----------|-----------|
| `+` | Soma |
| `-` | Subtração |
| `*` | Multiplicação |
| `/` | Divisão |
| `%` | Resto da divisão (módulo) |

Exemplos:

```csharp
int a = 1 + 1;
int b = 2 - 1;
int c = 3 * 2;
double d = 4 / 2.0;
int e = 5 % 2;
```

---

# Potenciação e Raiz

```csharp
double potencia = Math.Pow(2, 3); // 8
double raiz = Math.Sqrt(4);       // 2
```

---

# Ordem de Precedência

A ordem das operações é:

1. `()`
2. `*`, `/`, `%`
3. `+`, `-`

Exemplo:

```csharp
double resultado = 1 + (1 - (2 * 3)) / 4;
```

---

# Operadores Relacionais

| Operador | Significado |
|----------|-------------|
| `==` | Igual |
| `!=` | Diferente |
| `>` | Maior |
| `<` | Menor |
| `>=` | Maior ou igual |
| `<=` | Menor ou igual |

---

# Operadores Lógicos

| Operador | Significado |
|----------|-------------|
| `&&` | E |
| `||` | OU |
| `!` | NÃO |

Exemplo:

```csharp
bool resultado = idade >= 18 && possuiCNH;
```

---

# Incremento e Decremento

```csharp
int x = 0;

x++;   // x = x + 1
x--;   // x = x - 1

x += 2;
x -= 2;
x *= 2;
x /= 2;
x %= 2;
```

Exemplo:

```csharp
int x = 0;

Console.WriteLine(x); // 0

x++;
Console.WriteLine(x); // 1

x--;
Console.WriteLine(x); // 0
```

---

# Exemplo Completo

```csharp
using static System.Console;

Title = "SENAI | BACKEND";
Beep(500, 500);

string escola = "AMERICANA";

WriteLine($"SENAI {escola}\n");

BackgroundColor = ConsoleColor.DarkBlue;
ForegroundColor = ConsoleColor.Green;
WriteLine("SENAI | BACKEND");

BackgroundColor = ConsoleColor.Black;
ForegroundColor = ConsoleColor.White;
WriteLine("Americana - SP");

double numero = 1.787654321;
WriteLine($"Número: {numero:n}");

ReadKey();
```

---

# Resumo dos Operadores

## Aritméticos

```text
+  Soma
-  Subtração
*  Multiplicação
/  Divisão
%  Resto da divisão
++ Incremento
-- Decremento
+= Soma e atribui
-= Subtrai e atribui
*= Multiplica e atribui
/= Divide e atribui
%= Resto e atribui
```

## Relacionais

```text
== Igual
!= Diferente
>
<
>=
<=
```

## Lógicos

```text
&&  E
||  OU
!   NÃO
```

---

# Dicas

- Sempre inicialize suas variáveis antes de utilizá-las.
- Utilize nomes descritivos para variáveis.
- Prefira interpolação (`$""`) ao invés de concatenação quando possível.
- Organize o código utilizando comentários apenas quando realmente agregarem valor.
- Utilize `ReadKey()` para impedir o fechamento imediato do console durante testes.