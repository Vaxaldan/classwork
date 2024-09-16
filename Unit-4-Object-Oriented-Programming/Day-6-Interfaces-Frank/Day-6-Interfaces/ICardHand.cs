namespace Day_6_Interfaces
{
    // Interface for behaviors/methods a Class wanting to be a CardHand must implement

    // Interfaces have:
    //    1. no data
    //    2. method signatures of the methods they require
    //
    // a method signature:   returnType name(parameters);
    
    public interface ICardHand
    {
        // Draw a card(add a card to the hand)
        void AddCard(PlayingCard cardToAdd);

        // Discard a card(remove a card from the hand)
        void RemoveCard(PlayingCard cardToRemove);

        // Organize cards based on some criteria(values, suit, color, what makes you feel lucky)
        void SortHand(string howToSort);

        // Throw the hand in (folding, clear the hand of cards)
        void ThrowInHand();
        
        // Show itself(display the value, color, suit of all cards in the hand)
        void ShowHand();

        // Return a card from a specific position (1-based value) in the hand
        PlayingCard GetCardAtPosition(int position);

        // Return initial number of cards to be dealt to a hand
        int GetInitialCardsInHand();

        // Return maximum number of cards allowed to be dealt to a hand
        int GetMaxCardsInHand();
    }
}