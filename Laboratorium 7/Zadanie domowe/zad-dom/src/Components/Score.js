import React, { useEffect } from 'react';

const Score = (props) => {

    useEffect(() => {
		// on component umount
		return () => {
			console.log('aaavvv');
		};
	}, []);

	return (
		<div className='card'>
			<div className='value'>{props.value}/{props.all}</div>
		</div>
	);
};

export default Score;