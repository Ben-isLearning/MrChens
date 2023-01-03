import React, { Component } from 'react';

export class RamenShop extends Component {
    static displayName = RamenShop.name;

    constructor(props) {
        super(props);
        this.state = { currentCount: 0 };
        this.incrementRamenShop = this.incrementRamenShop.bind(this);
    }

    incrementRamenShop() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    render() {
        return (
            <div>
                <h1>Ramen Shop</h1>

                <p>This is a simple example of a React component.</p>

                <p aria-live="polite">Current count: <strong>{this.state.currentCount}</strong></p>

                <button className="btn btn-primary" onClick={this.incrementRamenShop}>Increment</button>
            </div>
        );
    }
}
