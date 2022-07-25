using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string Horizontal = "Horizontal";
        public string Vertical = "Vertical";

        public override Vector2 GenerateInput(string input = "Steer")
		{
			if (input.Equals("Steer"))
			{
				return new Vector2
				{
					x = Input.GetAxis(Horizontal),
					y = Input.GetAxis(Vertical)
				};
			}
			else if (input.Equals("Fire"))
			{
				return new Vector2
				{
					x = Input.GetAxis("Fire"),
					y = 0
				};
			}
			else
			{
				return new Vector2
				{
					x = 0,
					y = 0
				};
			}
        }

	}
}
