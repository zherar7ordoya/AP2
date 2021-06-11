; @author:  Gerardo Tordoya
; @date:    2021-06-10

INCLUDE 'emu8086.inc'
; Biblioteca de funciones comunes (por ejemplo: PRINT).
; La lectura de la biblioteca es muy clarificadora. Puede consultarse en:
; github.com/AhmadNaserTurnkeySolutions/emu8086/blob/master/inc/emu8086.inc

ORG 100h
; La directiva ORG 100H indica  al ensamblador  que continue  el ensamblado a
; partir de la direccion dada por el argumento, en este caso 100H.

; //////////////////////////////////////////////////////////////////// VARIABLES

cociente DB ?           ; DB stays for Define Byte.
resto    DB ?           ; Signo de interrogacion: variable no inicializada.

; ///////////////////////////////////////////////////////////////////// PROGRAMA

LEA     si, pedido1     ;
; Pedir primer numero. (LEA) Load Effective Address: store effective address for
; pedido1 in register si (source index): LEA loads a pointer to the item you're
; addressing.

CALL    print_string
; recibe la direccion en el registro si para imprimirla, es decir, imprime el
; pedido1

CALL    scan_num        ; recibe el numero por teclado y lo aloja en cx
MOV     dx, cx          ; copia en dx lo guardado en cx (1er numero)
CALL    pthis           ; imprime la cadena en la posicion del cursor
DB      13, 10, 0       ; 13: CR / 10: LF / 0: Terminator for the string.

LEA     si, pedido2     ; Pedir 2do nro
CALL    print_string    ; LLamado a libreria (procedimiento de emu8086.inc)
CALL    scan_num        ; LLamado a libreria (procedimiento de emu8086.inc)
MOV     bx, cx          ; Copiar numero en bx
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 0       ; imprimir salto de linea y retorno de carro (CRLF)

; PRUEBA DE ESCRITORIO:
;   1er numero en dx y 2do en bx.
;   en cx ha quedado el 2do numero (puesto ahi originalmente por scan).

PRINT   '[1(+), 2(-), 3(*), 4(/)]?: '
CALL    scan_num        ; scan aloja (por ej.) un 4 en cx
MOV     ax, 2           ; copiamos un 2 en ax

CMP     ax, cx          ; en cx esta el nro de operacion (4 en nuestro ejemplo).
; Veamos un ejemplo para entender a CMP:
;       SUB cl, dl > resta de cl el valor de dl y almacena el resultado en cl.
; CMP tiene el mismo formato que SUB (por ejemplo: CMP ax, bx > es decir: ax-bx)
; tan sólo que ninguno de los registros es alterado. Si por ejemplo son iguales,
; el flag de cero se pondrá en uno.
; En realidad, CMP es un SUB que no almacena el resultado.

JE      restar          ; Jump if Equal (=)
JL      multiplicar     ; Jump if Less (<)
JG      sumar           ; Jump if Greater (>)
; Los saltos (jump), en este caso, actuan como si se tratasen de un switch. La
; pregunta seria como lo hacen. En ensamblador, los CMP están ligados a los
; JUMP para hacer justamente eso:
; CMP hizo una comparación. Esa comparacion, realizada en el procesador, alineo
; los flags. Y los JUMP leen justamente eso para realizar los saltos: los flags.
; Entonces:
;       JE: cuando ZF = 1
;       JL: cuando SF <> OF
;       JG: cuando ZF = 0 y SF = OF
; Luego de la resta, los flags pertinentes:
;       ZF (zero flag): Set if result is zero; cleared otherwise.
;       SF (sign flag): Set equal to high-order bit of result
;                       (0 if positive 1 if negative).
;       OF (overflow flag): Set if result is too large a positive number or too
;                           small a negative number (excluding sign bit) to fit
;                           in destination operand; cleared otherwise.

sumar: ; //-----------------------------------------------------------------=> *

ADD     dx, bx          ; 1er numero en dx y 2do en bx.
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Suma(+): ', 0
MOV     ax, dx          ; print_num imprime lo que hay en ax (no en dx)
CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ;

restar: ; //----------------------------------------------------------------=> *

SUB     dx, bx          ; 1er numero en dx y 2do en bx.
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Resta(-): ', 0

MOV     ax, dx
; el resultado se copia en ax. EXPLICACION: segun la libreria, "This macro
; defines a procedure that prints number in AX".

CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ; regreso a DOS

multiplicar: ; //-----------------------------------------------------------=> *

; 1er numero en dx y 2do en bx.
MOV     ax, 3           ;
CMP     ax, cx          ; en cx esta el nro de operacion (4 en nuestro ejemplo).

JNE     dividir
; Jump if Not Equal (<>). EXPLICACION: llegados a este punto es porque ax
; "virtualmente" (CMP no altera los registros, solo evalua los flags de la 
; operacion aritmetica realizada) quedo en -2. Habiendo salido de la evaluacion
; que es menor (es decir, al 2 asignado a ax se le resto o 3 o 4). Este salto
; determina que, si fue 3, que se quede , y la otra posibilidad, que sea 4,
; envia el flujo a dividir (recuerdese que 4 es el codigo de operacion ingresada
; por el usuario para la division).

MOV     ax, dx          ; copia en ax el 1er numero (ver siguiente: MUL).

MUL     bx
; NOTA: en las multiplicaciones, si el operando es de 8 bits (1 byte), el
;       acumulador es AL. Si el operando es de 16 bits, el acumulador es AX. El
;       resultado se almacena en AX o en el par DX-AX respectivamente, si el
;       operando es de 8 bits o 16 bits.
; Visto esto, podremos decir que "MUL Byte Ptr [CX]" va a multiplicar el byte
; que hay en la dirección que marca CX por el contenido que hay en AL, y una vez
; hecho esto, va a almacenarlo en AX. "MUL SI" Multiplicaría SI por el contenido
; de AX, almacenándose en el par AX-DX (la palabra superior, de más valor, se
; devolvería en DX, y la inferior en AX.
; En resumen, por eso se guardo en ax el primer numero pues va la multiplicacion
; va a ser procesada alli y alli tambien almacenado el resultado.

CALL    pthis           ; A ver, lo aclaremos: imprime la siguiente cadena...
DB      13, 10, 'Multiplicacion(*): ', 0                    ; ...esta cadena
CALL    print_num       ; procedimiento que imprime un número en el registro AX.
RET                     ; regreso (retorno) al sistema operativo (SO).

dividir: ; //---------------------------------------------------------------=> *

; 1er numero en dx y 2do en bx.
MOV     ax, dx          ; copia en ax el 1er numero.
MOV     bl, 5           ; pone en bl un 5. ***************

DIV     bl

; Para la división, el dividendo ha de estar en AX, y ser 16 bits por tanto. El
; divisor se indica en el operando, por ejemplo en DIV BL; este divisor estaría
; en BL. Se dividiría AX entre BL y el resultado quedaría en AL, quedando el
; resto en AH.
MOV     cociente, al    ; segun lo explicado: en "cociente" el cociente.
MOV     resto, ah       ; segun lo explicado: en "resto" el resto.

; LA IMPRESION SE HACE USANDO OTRA TECNICA, ESO ES TODO.------------------------

; PRUEBA DE ESCRITORIO: 44 / 5
;       En bl: 5
;       En al: 8
;       En ah: 4

MOV     dl, cociente    ; copia el valor "real" de cociente
ADD     dl, 48          ; 48 es el cero en la tabla ASCII
MOV     ah, 2           ; este 2 sera el codigo de operacion para INT 21h

; PRUEBA DE ESCRITORIO: 44 / 5
;       En bl: 5
;       En al: 8
;       En ah: 2
;       En dl: 56 (8 en ASCII)

CALL    pthis           ; imprime lo que viene a continuacion
DB      10, 13, 0       ; salto de linea
PRINT   "El cociente es "

INT     21h
; En ah tenemos 2 (02h). "INT 21h" es una interrupcion del DOS (es decir, se 
; interrumpe para dejar que el dos haga algo). Lo que "INT 21h" hace es una
; operacion cuyo codigo esta en ah. Y actualmente, ah=02h.
; Codigo de que es la operacion 02h?:
;   AH = 02h > WRITE CHARACTER TO STANDARD OUTPUT
; ...que escribe el codigo ASCII en dl a enviar al dispositivo de salida.

MOV     dl, resto       ; copia el valor "real" de resto
ADD     dl, 48          ; suma 48 (0 en ASCII) a dl
MOV     ah, 2           ; la funcion 02h escribe al dispositivo de salida
PRINT   " y el resto es "
INT     21h             ; escribe el dl (en nuestro ejemplo, 52 ASCII = 4)
RET                     ; regresa al DOS
; //------------------------------------------------------------------------=> *

pedido1 DB 'Ingrese el 1er numero: ', 0
pedido2 DB 'Ingrese el 2do numero: ', 0          

; ///////////////////////////////////////////////////////////////// DEFINICIONES

DEFINE_SCAN_NUM         
; procedure that gets the multi-digit SIGNED number from the keyboard, and
; stores the result in CX register.

DEFINE_PRINT_STRING     
; procedure to print a null terminated string at current cursor position,
; receives address of string in DS:SI register.

DEFINE_PRINT_NUM        ; procedure that prints a signed number in AX register.

DEFINE_PRINT_NUM_UNS    ; required for print_num.

DEFINE_PTHIS            
; procedure to print a null terminated string at current cursor position (just
; as PRINT_STRING). The ZERO TERMINATED string should be defined just after the
; CALL. For example:
;                       CALL PTHIS
;                       db 'Hello World!', 0

; // *----------------------------------------------------------------------=> *

END