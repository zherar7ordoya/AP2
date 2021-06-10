INCLUDE 'emu8086.inc'   ; Biblioteca de funciones comunes (por ejemplo: PRINT).
ORG 100h
; La directiva ORG 100H indica  al ensamblador  que continue  el ensamblado a
; partir de la direccion dada por el argumento, en este caso 100H.

; //////////////////////////////////////////////////////////////////// VARIABLES

cociente DB ?           ; DB stays for Define Byte.
resto    DB ?           ;

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
DB      13, 10, 0       ; imprimir salto de linea y retorno de carro

PRINT   '[1(+), 2(-), 3(*), 4(/)]?: '
CALL    scan_num        ; LLamado a libreria (procedimiento de emu8086.inc)
MOV     ax, 2           ;
CMP     ax, cx          ;

JE      restar          ; Jump if Equal (=)
JL      multiplicar     ; Jump if Less (<)
JG      sumar           ; Jump if Greater (>)

sumar: ; //-----------------------------------------------------------------=> *

ADD     dx, bx          ;
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Suma(+): ', 0
MOV     ax, dx          ;
CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ;

restar: ; //----------------------------------------------------------------=> *

SUB     dx, bx          ;
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Resta(-): ', 0
MOV     ax, dx          ;
CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ;

multiplicar: ; //-----------------------------------------------------------=> *

MOV     ax, 3           ;
CMP     ax, cx          ;
JNE     dividir         ; Jump if Not Equal (<>).
MOV     ax, dx          ;
MUL     bx              ;
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 'Multiplicacion(*): ', 0
CALL    print_num       ; LLamado a libreria (procedimiento de emu8086.inc)
RET                     ;

dividir: ; //---------------------------------------------------------------=> *

MOV     ax, dx          ;
MOV     bl, 5           ;
DIV     bl              ;
MOV     cociente, al    ;
MOV     resto, ah       ;
MOV     dl, cociente    ;
ADD     dl, 48          ;
MOV     ah, 2           ;
CALL    pthis           ;
DB      10, 13, 0       ;
PRINT   "Division(/): "
INT     21h             ;
MOV     dl, resto       ;
ADD     dl, 48          ;
MOV     ah, 2           ;
PRINT   ". Resto: "
INT     21h             ;
RET                     ;
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