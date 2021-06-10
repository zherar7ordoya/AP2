INCLUDE 'emu8086.inc'
ORG 100h

; VARIABLES.---------------------------
cociente DB ?
resto    DB ?

; PROGRAMA.----------------------------
LEA     SI, numero1       ; pedir 1er nro
CALL    print_string
CALL    scan_num      ; get number in CX
MOV     DX, CX         ; copy the number to AX
CALL    pthis
DB      13, 10, 0

LEA     SI, numero2       ; pedir 2do nro
CALL    print_string
CALL    scan_num
MOV     BX, CX
CALL    pthis
DB      13, 10, 0

PRINT   '[1(+), 2(-), 3(*), 4(/)]?: '
CALL    scan_num
MOV     AX, 2
CMP     AX, CX

JE      l2 ; Jump if Equal (=)
JL      l3 ; Jump if Less (<)
JG      l1 ; Jump if Greater (>)
  
l1: ADD   DX, BX
    CALL  pthis
    DB    13, 10, 'Suma(+): ', 0
    MOV   AX, DX
    CALL  print_num
    RET

l2: SUB   DX, BX
    CALL  pthis
    DB    13, 10, 'Resta(-): ', 0
    MOV   AX, DX
    CALL  print_num
    RET

l3: MOV   AX, 3
    CMP   AX, CX
    JNE   l6 ; Jump if Not Equal (<>).
    MOV   AX, DX
    MUL   BX
    CALL  pthis
    DB    13, 10, 'Multiplicacion(*): ', 0
    CALL  print_num
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

DEFINE_SCAN_NUM
DEFINE_PRINT_STRING
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS    ;required for print_num
DEFINE_PTHIS

END