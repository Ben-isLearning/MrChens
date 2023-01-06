import React, { Component } from 'react';

export class ChangeLog extends Component {
    static displayName = ChangeLog.name;

    constructor(props) {
        super(props);
        this.state = { currentCount: 0 };
        this.incrementChangeLog = this.incrementChangeLog.bind(this);
    }

    incrementChangeLog() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    render() {
        return (
            <div>
                <h1>Change Log ~ Version: 0.12 </h1>
                <br></br>
                <p>This change log follows the journey of "Mr Chen" as he stumbles into the buisness of running a Ramen shop. <br />
                    I will be commenting the process of implementing "Mr Chen's" wacky ideas and buisness improvements. </p>
                <p>The aim of this exercise is that as the fictional "Mr Chen" grows as a buisness-owner, I too will grow as a developer </p>

                <table class="table table-striped w-100 border">
                    <tr>
                        <th>Version</th>
                        <th>Changes</th>
                        <th>Date</th>
                    </tr>
                    <tbody>
                        <tr>
                            <td>0</td>
                            <td>Initial Concept: Build a small app with limited functionality, <br /> then add further functionality and complexity as time goes by</td>
                            <td>03/01/2023</td>
                        </tr>
                        <tr>
                            <td>0.1</td>
                            <td>Added Title <br /> Added Change log component and route <br /> Added Ramen shop component and route <br /> Added Market component and route</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.2</td>
                            <td>Added 3 new components to the provided Nav Bar <br /> Kept Home and Fetch data for reference </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.2</td>
                            <td>Spent the entire day attempting to make and connect an SQL server in the manner it would be in an enterprise scale environment. <br />
                                Incredibly Difficult. Feels like i've been pounding a square peg into a round hole for the entire day. Atleast I've realised. <br />
                                In hindsight, I've found out two 'wrong' approaches. Now to find a 'right' one.</td>
                            <td>04/01/2023</td>
                        </tr>
                        <tr>
                            <td>0.3</td>
                            <td>Followed along with:
                                <a rel="noreferrer" href="https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database" target="_blank">
                                    Microsoft's Code First to a New Database</a><br />
                                Added 3 new Data models, 1 database context and 3 migrations <br />
                                Now to add an API so the web app can communicate with the Database</td>
                            <td>05/01/2023</td>
                        </tr>
                        <tr>
                            <td>0.4</td>
                            <td>Added SwaggerUI Into React project </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.5</td>
                            <td>Set up database with desired tables, rather than the tables setup when following
                                <a rel="noreferrer" href="https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database" target="_blank">This</a> tutorial <br />
                                Ran into an error, using Add-Migration and Update-Database, Deleted the branch and tried again, <br />
                                Re-attempted and ran into a persistant error: Cannot drop 'ThisTable' because it doesn't exist... <br />
                                Ended up Downloading Microsoft SQL Server Management Studio to manually override the Migration.cs file that <br />
                                was lingering through the branch deletion. <br />
                                After fixing that, Re-named Tables and their Models, and their Variables. <br />
                                Database Looks functional, and all before lunch, Woo.
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.6</td>
                            <td>Added back-end API Structure; Front End - Controller - Handler - Repository - Database Structure <br />
                                React App - CustomerController.cs - ICustomerHandler.cs -  ICustomerRepository.cs - IMrChensContext.cs  <br />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.7</td>
                            <td>Added Single API Call ~ AddCustomer <br />
                                Create; Able to Add a record to the Customers Table.  <br />
                                Route: localhost:44471/Customer/AddCustomer <br />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.8</td>
                            <td>Added Single API Call ~ GetCustomerById <br />
                                Get; Able to get a single record from the Customers Table dependant on id.  <br />
                                Route: localhost:44471/Customer/GetCustomerById/1008  <br />
                                Shows the JSON structure for "Mrs Chen"
                            </td>
                            <td>06/01/2023</td>
                        </tr>
                        <tr>
                            <td>0.9</td>
                            <td>Added Single API Call ~ GetCustomers <br />
                                Get; Able to get all records from the Customers Table.  <br />
                                Route: localhost:44471/Customer/GetCustomers  <br />
                                Shows the JSON structure for all table entries.
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.10</td>
                            <td>Added Single API Call ~ DeleteCustomer <br />
                                Delete; Able to Delete a single record from the Customers Table dependant on id.  <br />
                                Route: localhost:44471/Customer/DeleteCustomer/1008 <br />

                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.11</td>
                            <td>Added Single API Call ~ UpdateCustomer <br />
                                Update; Able to Update(Or Add) a single record of the Customers Table (If it doesn't exist).  <br />
                                Route: localhost:44471/Customer/UpdateCustomer <br />

                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>0.12</td>
                            <td>Added API Stack For Ingedients Table <br />
                                Repository - Handler - Controller - FrontEnd<br />
                                Context.cs implements DbContext, Context.cs implements IContext.cs <br/> 
                                Repository.cs uses a private version of IContext.cs <br/>
                                Repository.cs Implements IRepoitory.cs <br />
                                Handler.cs uses a private version of IRepository.cs <br/>
                                Handler.cs implements IHandler.cs <br />
                                Controller.cs uses a private version of IHandler.cs <br />
                                Controller.cs Implmenets IController.cs <br></br>
                                <br></br> 
                                This approach ensures we implement SOLID practices <br></br>
                                S - Each class only does one thing, ex, Repository.cs only interacts with our Database. <br></br>
                                O - We added functionality by adding more classes, we did not touch existing classes. <br></br>
                                L - Controller inherits from BaseController and extends functionality. <br></br>
                                I - Interfaces Segregate classes from eachother. <br></br>  
                                D - Each Class only depends on a interface, rather than a class. <br></br>
                            </td>
                            <td></td>
                        </tr>

                    </tbody>

                </table>
            </div>
        );
    }
}