; Autor:                Gerardo Tordoya
; Fecha:                2021-06(JUN)-12
; Final:                2021-07(JUL)-02

; -----------------------------------------------------------------------------
; NOTA:
; Hubiera querido implementar validaciones, pero no llego con el tiempo.
; A esta calculadorita le puse empeño, pero se que (por tratarse de un lenguaje
; que no uso) que esta sera la version final.
; -----------------------------------------------------------------------------

INCLUDE 'emu8086.inc'   ; [1]
ORG 100h                ; [2]

; //////////////////////////////////////////////////////////////////// VARIABLES

cocient DB ?            ; DB stays for Define Byte.
resto   DB ?            ; Signo de interrogacion: variable no inicializada.

; //////////////////////////////////////////////////////////////////// PROGRAMA

PRINTN  'MICRO-CALCULADORA'
CALL    pthis           ; Imprimir lo siguiente:
DB      10, 13, 0       ; CRLF

;                       -------------------------------------------------------

LEA     si, txt1        ; [3]
CALL    print_string    ; [4]
CALL    scan_num        ; Recibe el numero por teclado y lo aloja en CX
MOV     dx, cx          ; Copia en DX lo guardado en CX (1er numero)
CALL    pthis           ; Imprime la cadena en la posicion del cursor
DB      13, 10, 0       ; 13: CR / 10: LF / 0: Terminator for the string.

;                       REPITE LOGICA DEL 1ER BLOQUE.
LEA     si, txt2        ; Pedir 2do nro
CALL    print_string    ; LLamado a libreria (procedimiento de emu8086.inc)
CALL    scan_num        ; LLamado a libreria (procedimiento de emu8086.inc)
MOV     bx, cx          ; Copiar numero en bx
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 0       ; imprimir salto de linea y retorno de carro (CRLF)

;                       PRUEBA DE ESCRITORIO.
;                       1er numero en DX, 2do numero en BX.
;                       Scan dejo en CX ha quedado el 2do numero (puesto ahi 
;                       originalmente por el mismo scan).

CALL    pthis           ; Imprimir lo siguiente:
DB      10, 13, 0       ; CRLF
PRINTN  'Codigo de operacion: '
CALL    pthis           ; Imprimir lo siguiente:
DB      10, 13, 0       ; CRLF

PRINTN  '  1) Suma'
PRINTN  '  2) Resta'
PRINTN  '  3) Multiplicacion'
PRINTN  '  4) Division'

CALL    pthis           ; Imprimir lo siguiente:
DB      10, 13, 0       ; CRLF

CALL    scan_num        ; Scan aloja el codigo de operacion en CX
MOV     ax, 2           ; Copiamos un 2 en AX
CALL    pthis           ; Imprimir lo siguiente:
DB      10, 13, 0       ; CRLF

CMP     ax, cx          ; [5] [6]
JE      restar          ; Jump if Equal (=)
JL      multiplicar     ; Jump if Less (<)
JG      sumar           ; Jump if Greater (>)

sumar:                  ; -----------------------------------------------------
ADD     dx, bx          ; 1er numero en dx y 2do en bx.
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Total suma = ', 0
MOV     ax, dx          ; print_num imprime lo que hay en ax (no en dx)
CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ; salida del programa

restar:                 ; -----------------------------------------------------
SUB     dx, bx          ; 1er numero en dx y 2do en bx.
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Total resta = ', 0
MOV     ax, dx          ; [7]
CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ; regreso a DOS

multiplicar:            ; 1er numero en DX y 2do en BX.------------------------
MOV     ax, 3           ; con este 3 se decidira si es MUL o DIV
CMP     ax, cx          ; en cx esta el nro de operacion (4 en nuestro ejemplo).
JNE     dividir         ; [8]
MOV     ax, dx          ; copia en ax el 1er numero (ver siguiente: MUL).
MUL     bx              ; [9]
CALL    pthis           ; imprime la cadena de la siguiente linea
DB      13, 10, 'Total multiplicacion = ', 0
CALL    print_num       ; procedimiento que imprime un numero en el registro AX.
RET                     ; regreso (retorno) al sistema operativo (SO).

dividir:                ; 1er numero en DX y 2do en BX.------------------------
MOV     ax, dx          ; copia en AX el 1er numero.
DIV     bl              ; [10]
MOV     cocient, al     ; segun lo explicado: en "cocient" el cociente.
MOV     resto, ah       ; segun lo explicado: en "resto" el resto.

;                       IMPRIMIR UNA DIVISION. Todo un tema. Al quedar "divido"
;                       el resultado (en AL el cocient y en AH el resto), el 
;                       print_num no funcionara. Asi que hay que operar.

MOV     dl, cocient     ; copia el valor "real" del cociente
ADD     dl, 48          ; 48 es el cero en la tabla ASCII
MOV     ah, 2           ; este 2 sera el codigo de operacion para INT 21h
CALL    pthis           ; Imprime lo que viene a continuacion (que es: un CRLF)
DB      10, 13, 0       ; Un salto de linea (un CRLF)
PRINT   'Total division = '
INT     21h             ; [11]

;                       PARA EL COCIENTE, SE REPITE EL PROCESO ANTERIOR.
MOV     dl, resto       ; copia el valor "real" de resto
ADD     dl, 48          ; suma 48 (0 en ASCII) a dl
MOV     ah, 2           ; la funcion 02h escribe al dispositivo de salida
PRINT   ' | (resto) = '
INT     21h             ; imprime DL (en nuestro ejemplo, 52 ASCII = 4)

;                       -------------------------------------------------------

RET                     ; regresa al DOS

;                       -------------------------------------------------------

txt1     DB 'Ingrese  un  entero: ', 0
txt2     DB 'Ingrese otro entero: ', 0       

; //////////////////////////////////////////////////////////////// DEFINICIONES

DEFINE_SCAN_NUM         ; [12]
DEFINE_PRINT_STRING     ; [13]
DEFINE_PRINT_NUM        ; procedure that prints a signed number in AX register.
DEFINE_PRINT_NUM_UNS    ; required for print_num.
DEFINE_PTHIS            ; [14]

;                       -------------------------------------------------------

END

; /////////////////////////////////////////////////////////////////////////////

; [1]
; Biblioteca de funciones comunes (por ejemplo: PRINT).
; La lectura de la biblioteca es muy clarificadora. Puede consultarse en:
; github.com/AhmadNaserTurnkeySolutions/emu8086/blob/master/inc/emu8086.inc


; [2]
; La directiva ORG 100H indica  al ensamblador  que continue  el ensamblado a
; partir de la direccion dada por el argumento, en este caso 100H.


; [3]
; Pedir primer numero. (LEA) Load Effective Address: store effective address
; for txt1 in register SI (source index): LEA loads a pointer to the item
; you're addressing.


; [4]
; recibe la direccion en el registro SI para imprimirla, es decir, imprime el
; txt1 (es un puntero, bah!)


; [5] 
; En CX esta el codigo de operacion.
; Veamos un ejemplo para entender CMP: "SUB CL, DL" resta de CL el valor de DL
; y almacena el resultado en CL.
; CMP tiene el mismo formato que SUB (por ejemplo: CMP AX, BX es decir: AX-BX)
; tan solo que ninguno de los registros es alterado. Si por ejemplo son iguales,
; el flag de cero se pondra en 1.
; En realidad, CMP es un SUB que no almacena el resultado.


; [6]
; Los saltos (jump), en este caso, actuan como si se tratasen de un switch. La
; pregunta seria como lo hacen. En ensamblador, los CMP estan ligados a los
; JUMP para hacer justamente eso:
; CMP hizo una comparacion. Esa comparacion, realizada en el procesador, alineo
; los flags. Y los JUMP leen justamente eso para realizar los saltos: flags.
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


; [7]
; el resultado se copia en ax. EXPLICACION: segun la libreria, "This macro
; (print_num) defines a procedure that prints number in AX", y por eso hay que
; copiar el valor de DX en AX.


; [8]
; Jump if Not Equal (<>). EXPLICACION: llegados a este punto es porque ax
; "virtualmente" (CMP no altera los registros, solo evalua los flags de la 
; operacion aritmetica realizada) quedo en -2. Habiendo salido de la evaluacion
; que es menor (es decir, al 2 asignado a ax se le resto o 3 o 4). Este salto
; determina que, si fue 3, que se quede , y la otra posibilidad, que sea 4,
; envia el flujo a dividir (recuerde que 4 es el codigo de operacion ingresada
; por el usuario para la division).


; [9]
; NOTA: en las multiplicaciones, si el operando es de 8 bits (1 byte), el
;       acumulador es AL. Si el operando es de 16 bits, el acumulador es AX. El
;       resultado se almacena en AX o en el par DX-AX respectivamente, si el
;       operando es de 8 bits o 16 bits.
; Visto esto, podremos decir que "MUL Byte Ptr [CX]" va a multiplicar el byte
; que hay en la direccion que marca CX por el contenido que hay en AL. Una vez
; hecho esto, va a almacenarlo en AX. "MUL SI" multiplicara SI por el contenido
; de AX, almacenandose en el par AX-DX (la palabra superior, de mas valor, se
; devolvera en DX, y la inferior en AX.
; En resumen, por eso se guardo en AX el primer numero pues la multiplicacion va
; a ser procesada alli (y alli tambien se almacenara el resultado).


; [10]
; Para la division, el dividendo ha de estar en AX y ser de 16 bits. El divisor
; se indica en el operando, por ejemplo: "DIV BL". Este divisor estaria en BL.
; Se dividira AX entre BL y el cocient quedara en AL y el resto en AH.


; [11]
; En AH tenemos un 2 (02h). "INT 21h" es una interrupcion del DOS (es decir, se
; interrumpe para dejar que el DOS haga algo). Lo que "INT 21h" hace es una
; operacion cuyo codigo esta en AH. Y actualmente, AH=02h.
; Que hace "02h": AH = 02h > WRITE CHARACTER TO STANDARD OUTPUT
; En nuestro caso, imprime el equivalente en codigo ASCII del valor en DL.


; [12]
; procedure that gets the multi-digit SIGNED number from the keyboard, and
; stores the result in CX register.


; [13]
; procedure to print a null terminated string at current cursor position,
; receives address of string in DS:SI register.


; [14]
; procedure to print a null terminated string at current cursor position (just
; as PRINT_STRING). The ZERO TERMINATED string should be defined just after the
; CALL. For example:
;               CALL PTHIS
;               db 'Hello World!', 0

