
export default class Cart {
    constructor() {
        this.items = []
    }

    render() {
        return (
            <div>
                <h2>{this.items.length}</h2>
            </div>
        );
    }

    addItem = (newItem) => {
        this.items.push(newItem)
    }
}
