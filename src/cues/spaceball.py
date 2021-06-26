from src.tickflow import Cue

class BallOutCue(Cue):
    def __init__(self, beat, params):
        self.cue = "0x100"
        super().__init__(beat, params)