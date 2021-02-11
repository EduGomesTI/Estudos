import socket
import time
def pscan(host, port):
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    if s.connect_ex((host, port)):
        print("Port ", port, "Is Closed.")
    else:
        print("Port ", port, "Is Open.")