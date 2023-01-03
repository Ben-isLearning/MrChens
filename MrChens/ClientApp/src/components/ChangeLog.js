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
                <h1>Change Log ~ Version: 0.2 </h1>
                <br></br>
                <p>This change log follows the journey of "Mr Chen" as he stumbles into the buisness of running a Ramen shop. <br/>
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
                        <td>Initial Concept: Build a small app with limited functionality, <br/> then add further functionality and complexity as time goes by</td>
                        <td>03/01/2023</td>
                        </tr>
                    <tr>
                        <td>0.1</td>
                        <td>Added Title <br/> Added Change log component and route <br/> Added Ramen shop component and route <br/> Added Market component and route</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>0.2</td>
                        <td>Added 3 new components to the provided Nav Bar <br/> Kept Home and Fetch data for reference </td>
                        <td></td>
                    </tr>

                    </tbody>

                </table>
            </div>
        );
    }
}