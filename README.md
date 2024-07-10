# Yard-Management-System
The motto or guiding principle for a Yard Management System (YMS) could be
something along these lines:
"Optimizing Yard Efficiency, Enhancing Supply Chain Visibility"
The key aspects that a YMS motto could emphasize are:
1. Optimize Yard Operations: The primary goal of the Yard Management System
(YMS) is to optimize the operations and utilization of the storage yard. This
includes efficient use of space, streamlining material handling, and minimizing
delays to enhance overall productivity and efficiency.
2. Real-Time Visibility and Control: The YMS provides real-time visibility into
yard activities and inventory, improving decision-making, planning, and
coordination across the supply chain. The ability to control and monitor both
planned and unplanned activities reduces risks and enhances security.
3. Integrated Supply Chain Management: The YMS seamlessly integrates with
other supply chain systems, such as transportation management, warehouse
management, and ERP. This integration enables a holistic view of end-to-end
supply chain operations, improving overall efficiency.
4. Enhanced Efficiency and Productivity: The YMS drives increased efficiency
and productivity in the yard by reducing manual effort and errors. Automation,
data-driven decision-making, and process optimization are key components to
achieving this goal, ensuring smoother yard operations.
5. Compliance and Safety: The YMS ensures compliance with industry
regulations and maintains high safety standards in the yard. Proper tracking,
monitoring, and reporting of yard activities contribute to maintaining a safe and
compliant operational environment. Notifications for scheduled material
movements and live status updates further enhance yard management
security.
By encapsulating these key aspects, a YMS motto could inspire the development and
implementation of a system that truly optimizes yard operations and enhances the
overall supply chain performance.

DETAILS OF PROJECT:
Coil Movement App
The Coil Movement App is a Windows Forms application that simulates the movement of coils from a
saddle to a truck using a crane. The Yard Management System helps the organization manage yard
operations effectively. It tracks material movements, vehicle entries, and exits, ensuring the safety
and efficiency of yard operations.
Features
1. Coil Saddle: The application displays the coils currently on the saddle.
2. Crane Movement: The user can click the "GO" button to simulate the crane picking up a coil from
the saddle and placing it on the yard.
4. Coil Information: The application displays the details of the coil that is currently being moved,
including the coil ID, name, arrival time, and departure time.
5. Yard Display: Once all the coils have been moved to the truck, the application displays a message
indicating that the coils have been moved to the yard.
Code Structure
The Coil Movement App is composed of two main files:
1. Program.cs: This file contains the entry point of the application and creates an instance of the
`Form1` class.
2. Form1.cs: This file contains the implementation of the `Form1` class, which is the main form of the
application. It includes the following:
 - `saddleCoils` and `truckCoils` lists to store the coils on the saddle and the truck, respectively.
 - The `buttonMoveCrane_Click` event handler, which is called when the "Go" button is clicked. This
method simulates the movement of a coil from the saddle to the truck.
 - The `Coil` class, which represents a single coil with properties for the coil ID, name, arrival time,
and departure time.
3. Form1.Designer.cs: This file includes the code for the design of the front-end of the system. It
includes the properties of the resources used in the making of this system.
