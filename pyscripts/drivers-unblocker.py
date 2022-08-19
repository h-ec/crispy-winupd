import base64

mywcode = base64.b64encode(b"""
import threading
import keyboard
from pynput.mouse import Controller
from time import sleep
from win32api import GetSystemMetrics

def blockinput_start():
        mouse = Controller()
        global block_input_flag
        for i in range(150):
            keyboard.block_key(i)
        while block_input_flag == 1:
            mouse.position = (GetSystemMetrics(0) / 2, 0)
    
def blockinput_stop():
   global block_input_flag
   for i in range(150):
       keyboard.unblock_key(i)
   block_input_flag = 0

def blockinput():
    global block_input_flag
    block_input_flag = 1
    t1 = threading.Thread(target=blockinput_start)
    t1.start()
    

def unblockinput():
    blockinput_stop()


unblockinput()
""")

exec(base64.b64decode(mywcode))