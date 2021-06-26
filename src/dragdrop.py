from tkinter import *
from tkinter import messagebox, filedialog

root = Tk()

# Defining and grabbing images
NewButtonImage = [PhotoImage("images/NewButton.png"), PhotoImage("images/NewButtonPressed.png")]


# Creating Button Widgets
NewButton = Button(root, image=NewButtonImage[0], padx=2.5, pady=5)
SaveButton = Button(root, text="Save", padx=2.5, pady=5)

TimelineFrame = Frame(root)
la = Label(root, image=PhotoImage("images/NewButton.png"))

# Widgets for spacing everything out
Spacing1 = Label(root, padx=10, pady=10)

# Instantiating all widgets onto the grid
NewButton.grid(row=0, column=0)
SaveButton.grid(row=0, column=1)
Spacing1.grid(row=1, column=0, columnspan=10)
la.grid(row=0, column=3)

root.mainloop()