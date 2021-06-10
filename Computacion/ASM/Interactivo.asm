INCLUDE 'emu8086.inc'   ; Biblioteca de funciones comunes (ej.: PRINT).

ORG 100h

; // *--------------------------------------------------------------=> VARIABLES

cociente DB ?
resto    DB ?

; // *---------------------------------------------------------------=> PROGRAMA

LEA     SI, numero1     ; Pedir 1er nro
CALL    print_string    ; LLamado a libreria (procedimiento de emu8086.inc)
CALL    scan_num        ; Poner numero en CX (procedimiento de emu8086.inc)
MOV     DX, CX          ; copy the number to AX
CALL    pthis
DB      13, 10, 0

LEA     SI, numero2     ; Pedir 2do nro
CALL    print_string    ; LLamado a libreria (procedimiento de emu8086.inc)
CALL    scan_num        ; LLamado a libreria (procedimiento de emu8086.inc)
MOV     BX, CX
CALL    pthis           ; LLamado a libreria (procedimiento de emu8086.inc)
DB      13, 10, 0

PRINT   '[1(+), 2(-), 3(*), 4(/)]?: '
CALL    scan_num        ; LLamado a libreria (procedimiento de emu8086.inc)
MOV     AX, 2
CMP     AX, CX

JE      l2              ; Jump if Equal (=)
JL      l3              ; Jump if Less (<)
JG      l1              ; Jump if Greater (>)
  
l1: ADD   DX, BX
    CALL  pthis         ; LLamado a libreria (procedimiento de emu8086.inc)
    DB    13, 10, 'Suma(+): ', 0
    MOV   AX, DX
    CALL  print_num     ; LLamado a libreria (procedimiento de emu8086.inc)
    RET

l2: SUB   DX, BX
    CALL  pthis         ; LLamado a libreria (procedimiento de emu8086.inc)
    DB    13, 10, 'Resta(-): ', 0
    MOV   AX, DX
    CALL  print_num     ; LLamado a libreria (procedimiento de emu8086.inc)
    RET

l3: MOV   AX, 3
    CMP   AX, CX
    JNE   l6            ; Jump if Not Equal (<>).
    MOV   AX, DX
    MUL   BX
    CALL  pthis         ; LLamado a libreria (procedimiento de emu8086.inc)
    DB    13, 10, 'Multiplicacion(*): ', 0
    CALL  print_num     ; LLamado a libreria (procedimiento de emu8086.inc)
    RET

l6: MOV   AX, DX
    MOV   BL, 5
    DIV   BL
    MOV   cociente, AL
    MOV   resto, AH
    MOV   DL, cociente
    ADD   DL, 48
    MOV   AH, 2
    CALL  pthis
    DB    10, 13, 0
    PRINT "Division(/): "
    INT   21h
    MOV   DL, resto
    ADD   DL, 48
    MOV   AH, 2
    PRINT ". Resto: "
    INT   21h
    RET

numero1 DB 'Ingrese el 1er numero: ', 0
numero2 DB 'Ingrese el 2do numero: ', 0          

; // *-----------------------------------------------------------=> DEFINICIONES
; Fuente: https://jbwyatt.com/253/emu/asm_tutorial_05.html

DEFINE_SCAN_NUM         ; procedure that gets the multi-digit SIGNED number from
                        ; the keyboard, and stores the result in CX register.

DEFINE_PRINT_STRING     ; procedure to print a null terminated string at current
                        ; cursor position, receives address of string in DS:SI
                        ; register.

DEFINE_PRINT_NUM        ; procedure that prints a signed number in AX register.

DEFINE_PRINT_NUM_UNS    ; required for print_num.

DEFINE_PTHIS            ; procedure to print a null terminated string at current
                        ; cursor position (just as PRINT_STRING).
                        ; The ZERO TERMINATED string should be defined just
                        ; after the CALL. For example:
                        ;       CALL PTHIS
                        ;       db 'Hello World!', 0

END