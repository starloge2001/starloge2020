import pyautogui

file_a = pyautogui.locateOnScreen('a.png')
print(file_a)
pyautogui.click(file_a,duration=2)