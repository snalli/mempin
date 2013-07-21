class Instruction(object):
    """
    Representation of an instruction execution
    """

    def __init__(self,address=-1, thread=-1, library="", count=-1, time=-1):
        '''
        address - The address of the instruction
        thread - The ID of the thread that executed the instruction
        library - The name of the library that contains this instruction
        count - The number of instruction this was in the trace
        time - The wall clock time this instruction was executed
        '''
        self.address = address
        self.thread = thread
        self.library = library
        self.count = count
        self.time = time

    def __repr__(self):
        return "%08x\n%x\n%s\n%x\n%x" % (self.address, self.thread, self.library, self.count, self.time)

    def __getitem__(self, index):
        """
        This function allows us to reference the object using 
        indexes, such as instr[2] to return the library name
        """
        if index == 0:
            return "0x%08X" % self.address
        elif index == 1:
            return self.thread
        elif index == 2:
            return self.library
        elif index == 3:
            return self.count
        else:
            return self.time

