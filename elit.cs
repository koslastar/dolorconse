/// Draws the element with the specified opacity.
/// <param name="element">The UI element to be drawn.</param>
/// <param name="opacity">The opacity value ranging from 0.0 (completely transparent) to 1.0 (completely opaque).</param>
public void DrawElementWithOpacity(UIElement element, double opacity) {
    element.Opacity = opacity;

    // Additional drawing logic can go here
}

// Example usage
UIElement myElement = new Button();
DrawElementWithOpacity(myElement, 0.75); // Sets the element's opacity to 75%
